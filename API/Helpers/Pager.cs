using API.Dtos;

namespace API.Helpers
{
    public class Pager<T> where T : class
    {
        public string Search {get; set;}
        public int PageIndex {get; set;}    
        public int PageSize {get; set;}
        public int Total {get; set;}
        public List<T> Registers {get; private set;}

        public Pager(){}

        public Pager(List<T> registers, int total, int pageIndex, int pageSize , string search){
           Total = total;
           PageSize = pageSize;
           PageIndex = pageIndex;
           Registers = registers;
           Search = search;
        }


        public int TotalPages{
            get{
                return (int)Math.Ceiling(Total / (double)PageSize);
            }
    
        }

        public bool HasPreviousPage{
            get{
                return (PageIndex > 1);
            }

        }

        public bool HasNextPage{
            get{
                return(PageIndex < TotalPages);
            }
        
        }
    }
}