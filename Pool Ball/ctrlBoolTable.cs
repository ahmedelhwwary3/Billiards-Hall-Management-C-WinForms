using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Ball
{
    public partial class ctrlBoolTable : UserControl
    {
        public class BoolTableEventArgs:EventArgs
        {
            
            public TimeSpan ElapsedTime {  get; set; }
            public int PlayerCount {  get; set; }
            public float RequiredCash {  get; set; }
            public float HourlyCash {  get; set; }
            public BoolTableEventArgs(TimeSpan ElapsedTime,float RequiredCash, int PlayerCount,float HourlyCash)
            {
                this.ElapsedTime = ElapsedTime;
                this.PlayerCount = PlayerCount;
                this.RequiredCash = RequiredCash;
                this.HourlyCash = HourlyCash;
            }
        }
        public ctrlBoolTable()
        {
            InitializeComponent();
        }
        float _TotalSeconds = 0f;
        TimeSpan _time=TimeSpan.Zero;
        float _requierdCash=0f;
        private void Time_Tick(object sender, EventArgs e)
        {
            _TotalSeconds++;
            UpdateTimeElapsed();
            lblTime.Text = _time.ToString(@"hh\:mm\:ss");
            lblTime.Refresh();
        }
        private int _playerCount = 1;
        [Category("PoolConfigs"),
            Description("playerCount")]
        public int PlayerCount
        {
            get => _playerCount;
            set
            {
                _playerCount=value;
                if(_playerCount>0)
                {
                    lblPlayer.Text = "Player"+$" {_playerCount}";
                }
            }
        }
        private int _hourlyCash = 10;
        [Category("PoolConfigs"),
            Description("HourlyCash")]
        public int HourlyCash
        {
            get => _hourlyCash;
            set
            {
                _hourlyCash = value;
                if (_hourlyCash > 0)
                    lblHourlyCash.Text = $"{_hourlyCash} $" + "/HR";
            }
        }
        void UpdateTimeElapsed()
        {
            _time = TimeSpan.FromSeconds(_TotalSeconds);
        }
        public event EventHandler<BoolTableEventArgs> OnTableEnd;
        protected virtual void RaiseOnTableEndEvent(TimeSpan time,float requiredCash,int playerCount,float hourlyCash)
            => OnTableEnd?.Invoke(this,new BoolTableEventArgs(time, requiredCash, playerCount, hourlyCash));
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if(!TableTimer.Enabled)
            {
                btnStartStop.Text = "Stop";
                TableTimer.Start();
            }
            else
            {
                TableTimer.Stop();
                btnStartStop.Text = "Start";
            }
        }
        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            TableTimer.Stop();
            CalculateTablePayment();
            RaiseOnTableEndEvent(_time, _requierdCash, _playerCount,_hourlyCash);
            RefreshTable();
        }
        void CalculateTablePayment()
        {
            float TotalHours = _TotalSeconds / 3600;
            _requierdCash = TotalHours*_hourlyCash;
        }
        void RefreshTable()
        {
            _requierdCash = 0f;
            _TotalSeconds = 0;
            UpdateTimeElapsed();
            lblTime.Text = _time.ToString(@"hh\:mm\:ss");
            lblTime.Refresh();
        }
    }
}
