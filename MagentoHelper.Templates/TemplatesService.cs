using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoHelper.Templates
{
    public class TemplatesService
    {
        private string _moduleName;
        private string _companyName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleName"></param>
        /// <param name="companyName"></param>
        public TemplatesService(string moduleName, string companyName)
        {
            this._moduleName = moduleName;
            //BMJ by default
            this._companyName = companyName;
        }

        /// <summary>
        /// Replaces the blank tags in a template with values
        /// </summary>
        /// <param name="template"></param>
        /// <returns>formatted template</returns>
        public string PopulateTemplate(string template) {
            if (template.Contains(@"{1}"))
                return string.Format(template, this._companyName, this._moduleName);
            return string.Format(template, this._moduleName);
        }
    }
}
