using System;
using System.Collections.Generic;
using System.Text;

namespace BeastMaster.Models
{
  public class UrlQuery
  {
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public UrlQuery()
    {
      this.PageNumber = 1;
      this.PageSize = 10;
    }

    public UrlQuery(int pag)Number, int pageSize
    {
      this.PageNumber = PageNumber < 1 ? 1 : pageNunber;
      this.PageSize = pageSize > 10 ? 10 : pageSize;
    }
  }
}