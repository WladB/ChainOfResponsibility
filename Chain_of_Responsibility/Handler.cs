using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
  public class BaseHandler
    {
        protected BaseHandler next;
        public virtual object Handle(string request) {
            if (next != null)
            {
                return this.next.Handle(request);
            }
            else {
                return null;
            }
        }
        public BaseHandler SetNext(BaseHandler h) {
            this.next = h;
            return h;
        }
    }
    public class Bot : BaseHandler {
        public override object Handle(string request)
        {
            if (request.Contains("у мене не працює"))
            {
                return $"Спробуйте вимкнути та увімкнути знову { request.Substring(request.IndexOf("у мене не працює") + 17)}";
      
            }
            else
            {
                return base.Handle(request);
            }
        }
   
    }
    public class Operator : BaseHandler
    {
        public override object Handle(string request)
        {
            if (request.Contains("мені не допомогло"))
            {
                return $"Спробуйте ще раз { request.Substring(request.LastIndexOf("мені не допомогло") + 17)}";

            }
            else
            {
                return base.Handle(request);
            }
        }

    }
    public class geek : BaseHandler
    {
        public override object Handle(string request)
        {
            if (request.Contains("мені це також не допомогло"))
            {
                return $"Спробуйте щось окрім цього: { request.Substring(request.LastIndexOf("мені це також не допомогло") + 27)}";

            }
            else
            {
                return base.Handle(request);
            }
        }

    }
}
