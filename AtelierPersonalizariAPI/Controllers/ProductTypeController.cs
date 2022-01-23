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
    public class ProductTypeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<List<ProductType>> Get()
        {
            List<ProductType> list = await _unitOfWork.ProductTypeRepository.GetAll();
            return list;
        }

        [HttpGet("{id}")]
        public async Task<ProductType> Get(Guid id)
        {
            return await _unitOfWork.ProductTypeRepository.FindByIdAsync(id);
        }


        [HttpPost]
        public async void Post(ProductTypeDTO value)
        {
            ProductType model = new ProductType()
            {
                DateCreated = DateTime.UtcNow,
                Name = value.Name,
                ProductTypeProviderId = value.ProductTypeProviderId
            };
            await _unitOfWork.ProductTypeRepository.CreateAsync(model);
            _unitOfWork.Save();
        }


        [HttpPut("{id}")]
        public async Task Put(Guid id, ProductTypeDTO value)
        {
            ProductType model = await _unitOfWork.ProductTypeRepository.FindByIdAsync(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
                model.DateModified = DateTime.UtcNow;
            }
            if (value.ProductTypeProviderId != null)
            {
                model.ProductTypeProviderId = value.ProductTypeProviderId;
                model.DateModified = DateTime.UtcNow;
            }
            _unitOfWork.ProductTypeRepository.Update(model);
            _unitOfWork.Save();
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            ProductType model = await _unitOfWork.ProductTypeRepository.FindByIdAsync(id);
            _unitOfWork.ProductTypeRepository.Delete(model);
            await _unitOfWork.SaveAsync();
        }
    }
}
