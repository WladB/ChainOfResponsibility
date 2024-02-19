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
            if (request.Contains("не працює"))
            {
                return $"Спробуйте вимкнути та увімкнути знову { request.Substring(request.IndexOf("не працює") + 10)}";
      
            }
            if (request.Contains("не вмикається"))
            {
                return $"Спробуйте вимкнути та увімкнути знову живлення у { request.Substring(request.IndexOf("не вмикається") + 13)}";

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
                return $"Спробуйте ще раз { request.Substring(request.LastIndexOf("мені не допомогло") + 18)}";

            }
            else if (request.Contains("не допомагає")) {
                return $"Спробуйте ще раз { request.Substring(request.LastIndexOf("не допомагає") + 13)}";
            }
            else
            {
                return base.Handle(request);
            }
        }

    }
    public class Geek : BaseHandler
    {
        public override object Handle(string request)
        {
            if (request.Contains("також не допомогло"))
            {
                return $"Спробуйте щось окрім цього: { request.Substring(request.LastIndexOf("також не допомогло") + 19)}";

            }
            else
            {
                return base.Handle(request);
            }
        }

    }
}
