using Microsoft.AspNetCore.Mvc;
using DAL;
using Microsoft.AspNetCore.Cors;

namespace firstwebapi.Controllers;
using BOL;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAllProducts")]
    public IEnumerable<Products> Get()
    {
        List<Products> allProducts = DBManager.GetAllProducts();
        return allProducts;

    }

  [Route("{id}")]

    public IEnumerable<Products> Get(int id)
    {
        List<Products> getOneProd = DBManager.GetOneProduct( id);
        return getOneProd;

    }

[HttpPut]
// [EnableCors()]
[Route("update/{id}")]
    [HttpPut(Name = "UpdateProduct")]
    public ActionResult<Products> Update(int id){
        DBManager.UpdateProduct(id);
        return Ok(new {message="Data Updated Successfully"});
    }



// [EnableCors()]
[HttpDelete]
[Route("delete/{id}")]

    [HttpDelete(Name = "DeleteProduct")]
    public ActionResult<Products> Delete(int id)
    {
        DBManager.DeleteProduct(id); 
        return Ok (new {message="Product delete Succesfully"});

    }


    

[HttpPost]
[EnableCors()]
[Route("insert")]

    public IActionResult Insert(Products prod)
    {
        DBManager.InsertProduct(prod); 
        return Ok (new {message="Product save Succesfully"});

    }





}