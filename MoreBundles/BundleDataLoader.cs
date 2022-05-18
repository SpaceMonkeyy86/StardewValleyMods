using Newtonsoft.Json;
using StardewModdingAPI;
using System.IO;

namespace MoreBundles
{
    class BundleDataLoader : IAssetLoader
    {
        public bool CanLoad<T>(IAssetInfo asset) => asset.AssetNameEquals("Data\\ExpertBundles");
        public T Load<T>(IAssetInfo asset) => JsonConvert.DeserializeObject<T>(File.ReadAllText(Path.Combine(ModEntry.ModHelper.DirectoryPath, "assets", "Bundles.json")));
    }
}
