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
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<List<Product>> Get()
        {
            List<Product> list = await _unitOfWork.ProductRepository.GetAll();
            return list;
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(Guid id)
        {
            return await _unitOfWork.ProductRepository.FindByIdAsync(id);
        }


        [HttpPost]
        public async void Post(ProductDTO value)
        {
            Product model = new Product()
            {
                DateCreated = DateTime.UtcNow,
                Name = value.Name,
                Description = value.Description,
                Price = value.Price,
                Quantity = value.Quantity,
                ProductTypeId = value.ProductTypeId
            };
            await _unitOfWork.ProductRepository.CreateAsync(model);
            _unitOfWork.Save();
        }


        [HttpPut("{id}")]
        public async Task Put(Guid id, ProductDTO value)
        {
            Product model = await _unitOfWork.ProductRepository.FindByIdAsync(id);
            if (value.Name != null)
            {
                model.Name = value.Name;
                model.DateModified = DateTime.UtcNow;
            }
            if (value.Description != null)
            {
                model.Description = value.Description;
                model.DateModified = DateTime.UtcNow;
            }
            if (value.Price != null)
            {
                model.Price = value.Price;
                model.DateModified = DateTime.UtcNow;
            }
            if (value.Quantity != null)
            {
                model.Quantity = value.Quantity;
                model.DateModified = DateTime.UtcNow;
            }
            if (value.ProductTypeId != null)
            {
                model.ProductTypeId = value.ProductTypeId;
                model.DateModified = DateTime.UtcNow;
            }
            _unitOfWork.ProductRepository.Update(model);
            _unitOfWork.Save();
        }


        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            Product model = await _unitOfWork.ProductRepository.FindByIdAsync(id);
            _unitOfWork.ProductRepository.Delete(model);
            await _unitOfWork.SaveAsync();
        }
    }
}
