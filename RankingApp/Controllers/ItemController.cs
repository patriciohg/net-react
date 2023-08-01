using Microsoft.AspNetCore.Mvc;
using RankingApp.NewFolder;

namespace RankingApp.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase

    {

        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id=1, Title="The Godfather", ImageId=1, Ranking=0, ItemType=1},
            new ItemModel{Id=2, Title="The lord of the rings", ImageId=2,Ranking=0,ItemType=1},
            new ItemModel{Id=3, Title="Harry Potter", ImageId=3,Ranking=0,ItemType=1},
            new ItemModel{Id=4, Title="Star Wars", ImageId=4,Ranking=0,ItemType=1},
            new ItemModel{Id=5, Title="The Professional", ImageId=5,Ranking=0,ItemType=1}
        };
        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(x => x.ItemType == itemType).ToArray();
            return items;
        }

    }
}
