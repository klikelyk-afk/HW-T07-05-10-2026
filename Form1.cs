using PrinterLibrary;
using SharedInterfaces;

namespace WinFormsApp_Babylon_2026_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Instance.LogData(LogLevel.Debug, "Message 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logger.Instance.LogData(LogLevel.Warning, "Message 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(SetMessage);
            Thread thread2 = new Thread(SetMessage);

            thread1.Start(1);
            thread2.Start(2);
        }

        private void SetMessage(object n)
        {
            int number = (int)n;
            Logger.Instance.LogData(LogLevel.Error, $"Message from different thread. Number = {n}");
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string data = textBoxInputData.Text; // document to print
            var printerFactory = new PrinterFactory();
            IPrint printer = printerFactory.GetPrinter();
            printer.Print(data);
        }
    }
}
