
namespace DesingPatternsInForms.State
{
    internal class State
    {
        enum BulbState
        {
            On = 1,
            Off = 2,
        }

        private BulbState _currentBulbState = BulbState.Off;
        public string GetStatus()
        {
            return string.Format(@"Bulb is {0}", _currentBulbState);
        }

        public void PressSwitch()
        {
            if (_currentBulbState == BulbState.Off)
            {
                _currentBulbState = BulbState.On;
            }
            else
            {
                _currentBulbState = BulbState.Off;
            }
        }
    }
}
