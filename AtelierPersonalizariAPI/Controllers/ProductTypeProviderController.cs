using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtelierPersonalizariAPI.Repositories.UnitOfWork;
using AtelierPersonalizariAPI.Models;
using AtelierPersonalizariAPI.Models.DTOs;

namespace AtelierPersonalizariAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeProviderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductTypeProviderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<List<ProductTypeProvider>> Get()
        {
            List<ProductTypeProvider> list = await _unitOfWork.ProductTypeProviderRepository.GetAll();
            return list;
        }

        [HttpGet("{id}")]
        public async Task<ProductTypeProvider> Get(Guid id)
        {
            return await _unitOfWork.ProductTypeProviderRepository.FindByIdAsync(id);
        }


        [HttpPost]
        public async void Post(ProductTypeProviderDTO value)
        {
            ProductTypeProvider model = new ProductTypeProvider()
            {
                DateCreated = DateTime.UtcNow,
                Name = value.Name
            };
            await _unitOfWork.ProductTypeProviderRepository.CreateAsync(model);
            _unitOfWork.Save();
        }


        [HttpPut("{id}")]
        public async Task Put(Guid id, ProductTypeProviderDTO value)
        {
            ProductTypeProvider model = await _unitOfWork.ProductTypeProviderRepository.FindByIdAsync(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
                model.DateModified = DateTime.UtcNow;
            }
            _unitOfWork.ProductTypeProviderRepository.Update(model);
            _unitOfWork.Save();
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            ProductTypeProvider model = await _unitOfWork.ProductTypeProviderRepository.FindByIdAsync(id);
            _unitOfWork.ProductTypeProviderRepository.Delete(model);
            await _unitOfWork.SaveAsync();
        }
    }
}
