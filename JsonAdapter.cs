using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VirtualDesktopHelper
{
    public class JsonAdapter<T> where T : class
    {
        protected JsonSerializerSettings settings;

        public JsonAdapter(bool enumAsString = false)
        {
            settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            settings.TypeNameHandling = TypeNameHandling.All;
            if (enumAsString)
            {
                settings.Converters.Add(new StringEnumConverter());
            }
        }

        public virtual string Dump(T toBeDumped)
        {
            return JsonConvert.SerializeObject(toBeDumped, settings);
        }

        public virtual T Restore(string dumped)
        {
            return JsonConvert.DeserializeObject(dumped, settings) as T;
        }
    }

    public static class JsonAdapterExtensions
    {
        public static string ToJson<T>(this T instance) where T : class
        {
            JsonAdapter<T> adapter = new JsonAdapter<T>();
            return adapter.Dump(instance);
        }

        public static T RestoreFromJson<T>(this string serialized) where T : class
        {
            try
            {
                JsonAdapter<T> adapter = new JsonAdapter<T>();
                return adapter.Restore(serialized);
            }
            catch
            {
                //ignore
                return null;
            }
        }
    }
}