using System;
using System.Configuration;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ZXing;

namespace BarcodeCreator
{
    public partial class MainForm : Form
    {
        private int barcodeWidth;
        private int barcodeHeight;

        private int topMargin;
        private int yMargin;
        private int xMargin;

        private readonly Dictionary<string, BarcodeFormat> barcodeFormatMap
            = new Dictionary<string, BarcodeFormat>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MainFormのLoad時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!readBarcodeLayout())
            {
                // バーコードレイアウトの読み込みに失敗した場合は、アプリを終了する
                MessageBox.Show(
                    "バーコードレイアウト情報が不正です。\nApp.configの設定値を見直して下さい。",
                    "パラメータエラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                // インストールされてるプリンタ一覧を作成
                foreach (string printer in getPrinterList())
                {
                    this.PrinterList.Items.Add(printer);
                }

                foreach (string barcodeFormat in createBarcodeFormatList())
                {
                    this.BarcodeFormatList.Items.Add(barcodeFormat);
                }

                // 他
                this.PrinterList.SelectedIndex = 0;
                this.BarcodeFormatList.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 印刷ボタン押下時処理
        /// </summary>
        // <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e) => print();

        /// <summary>
        /// 印刷処理
        /// </summary>
        private void print()
        {
            var printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printHandler);
            printDocument.PrinterSettings.PrinterName = this.PrinterList.Text;
            printDocument.Print();
        }

        /// <summary>
        /// 印刷実行時コールバック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printHandler(object sender, PrintPageEventArgs e)
        {
            // バーコード生成オブジェクトを生成
            var barcodeWriter = new BarcodeWriter()
            {
                Format = barcodeFormatMap[this.BarcodeFormatList.Text]
            };
            // この辺は好みに合わせて調整すること
            barcodeWriter.Options.Width = this.barcodeWidth;
            barcodeWriter.Options.Height = this.barcodeHeight;
            barcodeWriter.Options.PureBarcode = false; // テキストも表示しとく

            int pos_x = 0; // 横座標
            int pos_y = this.topMargin; // 縦座標

            // 印刷イメージにバーコード画像をバンバン貼り付けてゆく
            for (int column = 0; column < this.CodeInputTable.ColumnCount; ++column)
            {
                for (int row = 0; row < this.CodeInputTable.RowCount; ++row)
                {
                    string code = this.CodeInputTable.GetControlFromPosition(column, row).Text;
                    if (!code.Equals(""))
                    {
                        try
                        {
                            // 入力されているコードのみをバーコード化し、貼り付ける
                            // (空文字列をWriteに渡すとArgumentExceptionが発生するので)
                            using (var bitmap = barcodeWriter.Write(code))
                            {
                                e.Graphics.DrawImage(bitmap, new Point(pos_x, pos_y));
                                bitmap.Dispose();
                            }
                        }
                        catch (ArgumentException)
                        {
                            // バーコードのフォーマット毎にそれぞれ異なる入力ルールがある(正直よくわからん)ので、
                            // いちいちチェックしない。一律ここでエラー文字列を貼り付ける。
                            using (var font = new Font("UTF-8", 20))
                            {
                                e.Graphics.DrawString($"Data Error !!\n{code}", font, Brushes.Red, pos_x, pos_y);
                                font.Dispose();
                            }
                        }
                    }
                    pos_y += (this.barcodeHeight + this.yMargin);
                }
                // 貼り付け位置を、次の列の先頭に調整
                pos_y = this.topMargin;
                pos_x += (this.barcodeWidth + this.xMargin);
            }
        }

        /// <summary>
        /// 入力内容クリアボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int column = 0; column < this.CodeInputTable.ColumnCount; ++column)
            {
                for (int row = 0; row < this.CodeInputTable.RowCount; ++row)
                {
                    this.CodeInputTable.GetControlFromPosition(column, row).Text = "";
                }
            }
        }

        /// <summary>
        /// バーコードのレイアウト情報を読み込む
        /// </summary>
        /// <returns>true : 読み込み成功 / false : 読み込み失敗</returns>
        private bool readBarcodeLayout()
        {
            bool isOk = true;
            // 設定ファイルの設定値を読み込む
            isOk &= Int32.TryParse(ConfigurationManager.AppSettings["topMargin"], out this.topMargin);
            isOk &= Int32.TryParse(ConfigurationManager.AppSettings["barcodeWidth"], out this.barcodeWidth);
            isOk &= Int32.TryParse(ConfigurationManager.AppSettings["barcodeHeight"], out this.barcodeHeight);
            isOk &= Int32.TryParse(ConfigurationManager.AppSettings["barcodeYMargin"], out this.yMargin);
            isOk &= Int32.TryParse(ConfigurationManager.AppSettings["barcodeXMargin"], out this.xMargin);

            return isOk;
        }

        /// <summary>
        /// インストールされているプリンタのリストを生成する
        /// </summary>
        /// <returns>インストールされているプリンタのリスト(遅延評価)</returns>
        private IEnumerable<string> getPrinterList()
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                yield return printer;
            }
        }

        /// <summary>
        /// バーコード種別のリストを作成する
        /// </summary>
        private IEnumerable<string> createBarcodeFormatList()
        {
            barcodeFormatMap.Add("Code 128",       BarcodeFormat.CODE_128);
            barcodeFormatMap.Add("Code 39",        BarcodeFormat.CODE_39);
            barcodeFormatMap.Add("Code 93",        BarcodeFormat.CODE_93);
            barcodeFormatMap.Add("Data Matrix 2D", BarcodeFormat.DATA_MATRIX);
            barcodeFormatMap.Add("EAN-13",         BarcodeFormat.EAN_13);
            barcodeFormatMap.Add("EAN-8",          BarcodeFormat.EAN_8);
            barcodeFormatMap.Add("ITF",            BarcodeFormat.ITF);
            barcodeFormatMap.Add("MaxiCode",       BarcodeFormat.MAXICODE);
            barcodeFormatMap.Add("PDF417",         BarcodeFormat.PDF_417);
            barcodeFormatMap.Add("QR Code",        BarcodeFormat.QR_CODE);
            barcodeFormatMap.Add("RSS14",          BarcodeFormat.RSS_14);
            barcodeFormatMap.Add("RSS EXPANDED",   BarcodeFormat.RSS_EXPANDED);
            barcodeFormatMap.Add("UPC-A",          BarcodeFormat.UPC_A);
            barcodeFormatMap.Add("UPC-E",          BarcodeFormat.UPC_E);
            barcodeFormatMap.Add("UPC/EAN",        BarcodeFormat.UPC_EAN_EXTENSION);

            foreach (string barcodeFormat in barcodeFormatMap.Keys)
            {
                yield return barcodeFormat;
            }
        }
    }
}
