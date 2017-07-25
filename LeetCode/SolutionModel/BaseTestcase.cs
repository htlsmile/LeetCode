using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace SolutionModel
{
    public abstract class BaseCaseModel
    {
        public virtual object[] Parameters
        {
            get
            {
                List<object> parameters = new List<object>();
                foreach (PropertyInfo pi in GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public))
                {
                    if (pi.Name != nameof(Result))
                    {
                        parameters.Add(pi.GetValue(this, null));
                    }
                }
                return parameters.ToArray();
            }
        }
        public virtual object Result { get; set; }
    }

    public abstract class BaseTestcase
    {
        public virtual string MainFuncName { get; set; }
        public virtual IEnumerable<BaseCaseModel> TestcaseList { get; set; }
    }
}
