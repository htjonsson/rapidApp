using System.Collections.Generic;
using rapidApp.Context;
using rapidApp.Domains;

namespace rapidApp.Repositories
{
    public class TemplateRepository
    {
        private readonly LiteDbContext _liteDbContext;

        public TemplateRepository() 
        {
            this._liteDbContext = new LiteDbContext();
        }

        public List<Template> GetAll()
        {
            return this._liteDbContext.GetAll<Template>(typeof(Template).Name);
        }

        public bool Save(Template template) 
        {
            return this._liteDbContext.Save<Template>(typeof(Template).Name, template);
        }

        public bool Delete(Template template) 
        {
            return this._liteDbContext.Delete(typeof(Template).Name, template.Id);
        }        
    }
}