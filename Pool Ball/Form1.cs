using static Pool_Ball.ctrlBoolTable;
namespace Pool_Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlBoolTable_OnTableEnd(object sender, BoolTableEventArgs e)
        {
            int TotalSecs = e.ElapsedTime.Seconds;
            int RemainedSecs;

            int Hours = TotalSecs / (3600);
            RemainedSecs = TotalSecs % (3600);
            int Mins = RemainedSecs / 60;
            RemainedSecs %= 60;

            int Secs;
            MessageBox.Show(
                $"Total Hours:{Hours}" +
                $"\nTotal Minutes:{Mins}" +
                $"\nTotal Secs:{RemainedSecs}" +
                $"\n\nPlayerCount:{e.PlayerCount}" +
                $"\nHourlyCash:{e.HourlyCash}" +
                $"\nRequiredCash:{e.RequiredCash}",
                "Table Details", MessageBoxButtons.OK);
        }
    }
}
