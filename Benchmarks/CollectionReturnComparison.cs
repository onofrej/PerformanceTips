using AutoFixture;
using BenchmarkDotNet.Attributes;

namespace PerformanceTips.Benchmarks
{
    [MemoryDiagnoser, RankColumn]
    public class CollectionReturnComparison
    {
        private readonly IEnumerable<Item> _items = new Fixture().CreateMany<Item>(100);

        [Benchmark]
        public CustomResponse WithYieldReturn()
        {
            return new CustomResponse()
            {
                Items = YieldReturn(_items)
            };
        }

        [Benchmark]
        public CustomResponse WithSelectReturn()
        {
            return new CustomResponse()
            {
                Items = _items.Select(selector => new ItemResponse { Id = selector.Id, Name = selector.Name })
            };
        }

        [Benchmark]
        public CustomResponse WithAddValues()
        {
            return new CustomResponse()
            {
                Items = AddValues(_items)
            };
        }

        public IEnumerable<ItemResponse> AddValues(IEnumerable<Item> items)
        {
            var itemsResponse = new List<ItemResponse>();

            foreach (var item in items)
            {
                itemsResponse.Add(new ItemResponse()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }

            return itemsResponse;
        }

        public IEnumerable<ItemResponse> YieldReturn(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                yield return new ItemResponse()
                {
                    Id = item.Id,
                    Name = item.Name
                };
            }
        }
    }

    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; }
    }

    public class ItemResponse
    {
        public string Name { get; set; } = string.Empty;
        public int Id { get; set; }
    }

    public class CustomResponse
    {
        public IEnumerable<ItemResponse> Items { get; set; } = new List<ItemResponse>();
    }
}