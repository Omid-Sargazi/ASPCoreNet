using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnhanceCodes.Models;
using EnhanceCodes.Services;
using Microsoft.AspNetCore.Mvc;

namespace EnhanceCodes.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly IProductService _productService;

    
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var product = await _productService.GetProductByIdAsync(id);
            if(product==null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (product == null || string.IsNullOrEmpty(product.Name) || product.Price <= 0)
                return BadRequest("Invalid product data.");
            
            var createdProduct = await _productService.CreateProductAsync(product);

            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Product updatedProduct)
        {

            if (updatedProduct == null || string.IsNullOrEmpty(updatedProduct.Name) || updatedProduct.Price <= 0)
                return BadRequest("Invalid product data.");

           var product = await _productService.UpdateProductAsync(id, updatedProduct);
           if(product==null)
                return NotFound();

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _productService.DeleteProductAsync(id);
            if (deleted == null)
                return NotFound();

            return NoContent();
        }
    }




}