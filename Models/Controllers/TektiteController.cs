
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eternalminerals.Models;

namespace eternalminerals.Controllers

{

  [ApiController]
  [Route("api/[controller]")]

  public class TektiteController : ControllerBase

  {

    [HttpGet] //type 1
    public ActionResult GetAllTektites()

    { //return list of all tektites, order by name

      var db = new DatabaseContext();
      return Ok(db.Tektites.OrderBy(x => x.Name));

    }

    [HttpGet("{id}")]
    public ActionResult GetOneStudent(int id)

    {

      var db = new DatabaseContext();
      var xTektite = db.Tektites.FirstOrDefault(x => x.Id == id);

      if (xTektite == null)

      {
        return NotFound();
      }

      else

      {
        return Ok(xTektite);
      }

    }


    [HttpGet("{sku}")] //why lowercase
    public ActionResult GetItemBySku(string sku)

    {

      var db = new DatabaseContext();
      var yTektite = db.Tektites.FirstOrDefault(y => y.Sku == sku);

      if (yTektite == null)

      {
        return NotFound();
      }

      else

      {
        return Ok(yTektite);
      }

    }

    // [HttpGet("{items/none}")] //why lowercase
    // public ActionResult TektiteOutOfStock(int Quantity)

    // {

    //   var db = new DatabaseContext();
    //   var zTektite = db.Tektites.Where(z => z.Quantity == 0).OrderByDescending(zTektite => zTektite.Stocked);

    //   if (zTektite == null)

    //   {
    //     return NotFound();
    //   }

    //   else

    //   {
    //     return Ok(zTektite);
    //   }

    // }

    [HttpPost] //type 2
    public ActionResult CreateTektite(Tektite tektite) //xTektite?

    {

      var db = new DatabaseContext();
      db.Tektites.Add(tektite);
      db.SaveChanges();
      return Ok(tektite);

    }

    [HttpPut("{id}")]//what happens with no id? - type 3
    public ActionResult UpdateTektite(Tektite tektite)

    {

      var db = new DatabaseContext(); //can you use const in C#
      var prevTektite = db.Tektites.FirstOrDefault(temp => temp.Id == tektite.Id); //difference between line 18, 25 and 51

      if (prevTektite == null)

      {
        return NotFound();
      }

      else

      {
        prevTektite.Name = tektite.Name; //xTektite?
        prevTektite.DefaultColor = tektite.Name;
        prevTektite.Hardness = tektite.Hardness;
        prevTektite.IsRare = tektite.IsRare;
        prevTektite.Sku = tektite.Sku;
        prevTektite.Bio = tektite.Bio;
        prevTektite.Quantity = tektite.Quantity;
        prevTektite.Price = tektite.Price;
        prevTektite.Stocked = tektite.Stocked;
        db.SaveChanges();
        return Ok(prevTektite);
      }

    }

    [HttpDelete("{id}")]// type 4
    public ActionResult DeleteTektite(int id) //line 46 vs 78?

    {

      var db = new DatabaseContext(); //can you use const in C#
      var xTektite = db.Tektites.FirstOrDefault(temp => temp.Id == id);

      if (xTektite == null)

      {
        return NotFound();
      }

      else

      {

        db.Tektites.Remove(xTektite);
        db.SaveChanges();
        return Ok(); //dont need to pass anything?

      }

    }

  }

}

