using System.Collections.Generic;
using rapidApp.Repositories;
using rapidApp.Domains;

namespace rapidApp.Services
{
    public class TemplateService
    {
        private readonly TemplateRepository _templateRepository;

        public TemplateService()
        {
            this._templateRepository = new TemplateRepository();
        }

        public List<Template> GetAll() 
        {
            return _templateRepository.GetAll();
        }
    }
}