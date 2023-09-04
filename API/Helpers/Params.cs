namespace API.Helpers
{
    public class Params
    {
        private int _pageSize = 5;
        private const int MaxPageSize = 50;
        private int _pageIndex = 1;
        private string _search ;

        public int PageSize{
            get { return _pageSize; }
            set { _pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public int PageIndex{
            get { return _pageIndex; }
            set { _pageIndex = (value <= 0) ? 1 : value; }
        }

        public string Search{
            get { return _search; }
            set => _search = (!String.IsNullOrEmpty(value)) ? value.ToLower() : "";
        }
    }
}