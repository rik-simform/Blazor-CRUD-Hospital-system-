using Blazored.SessionStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HospitalSystem.Client.Extensions
{
    public static class SessionStorageServiceExtensions
    {
        public static async Task SaveItemEncryptedAsync<T>(this ISessionStorageService sessionStorageService,string key, T item)
        {
            var itemjson = JsonSerializer.Serialize(item);
            var itemjsonBytes = Encoding.UTF8.GetBytes(itemjson);
            var base64Json = Convert.ToBase64String(itemjsonBytes);
            await sessionStorageService.SetItemAsync(key, base64Json);
        }

        public static async Task<T> ReadEncryptedItemAsync<T>(this ISessionStorageService sessionStorageService, string key)
        {
            var base64Json = await sessionStorageService.GetItemAsync<string>(key);
            var itemJsonBytes = Convert.FromBase64String(base64Json);
            var itemJson = Encoding.UTF8.GetString(itemJsonBytes);
            var item = JsonSerializer.Deserialize<T>(itemJson);

            return item;

        }
    }
}
