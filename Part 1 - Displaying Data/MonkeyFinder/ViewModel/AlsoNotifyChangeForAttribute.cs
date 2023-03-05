namespace MonkeyFinder.ViewModel
{
    internal class AlsoNotifyChangeForAttribute : Attribute
    {
        private string v;

        public AlsoNotifyChangeForAttribute(string v)
        {
            this.v = v;
        }
    }
}