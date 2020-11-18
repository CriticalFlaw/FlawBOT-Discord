﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlawBOT.Framework.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FlawBOT.Framework.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.amiiboapi.com/api/amiibo/?name={0}.
        /// </summary>
        internal static string API_Amiibo {
            get {
                return ResourceManager.GetString("API_Amiibo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://catfact.ninja/fact.
        /// </summary>
        internal static string API_CatFacts {
            get {
                return ResourceManager.GetString("API_CatFacts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://aws.random.cat/meow.
        /// </summary>
        internal static string API_CatPhoto {
            get {
                return ResourceManager.GetString("API_CatPhoto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.urbandictionary.com/v0/define?term={0}.
        /// </summary>
        internal static string API_Dictionary {
            get {
                return ResourceManager.GetString("API_Dictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://dog.ceo/api/breeds/image/random.
        /// </summary>
        internal static string API_DogPhoto {
            get {
                return ResourceManager.GetString("API_DogPhoto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.ipstack.com/{0}?access_key=2e3dea495fa72127ed0f03ccb0b141b9&amp;format=1.
        /// </summary>
        internal static string API_IPLocation {
            get {
                return ResourceManager.GetString("API_IPLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://api.nasa.gov/planetary/apod?api_key={0}.
        /// </summary>
        internal static string API_NASA {
            get {
                return ResourceManager.GetString("API_NASA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://newsapi.org/v2/everything?sources=google-news&amp;q={0}&amp;apiKey={1}.
        /// </summary>
        internal static string API_News {
            get {
                return ResourceManager.GetString("API_News", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.speedrun.com/api/v1/games?name={0}.
        /// </summary>
        internal static string API_Speedrun {
            get {
                return ResourceManager.GetString("API_Speedrun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.speedrun.com/api/v1/{0}/{1}.
        /// </summary>
        internal static string API_SpeedrunExtras {
            get {
                return ResourceManager.GetString("API_SpeedrunExtras", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://api.weatherstack.com//current?access_key={0}&amp;query={1}.
        /// </summary>
        internal static string API_Weather {
            get {
                return ResourceManager.GetString("API_Weather", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error updating the Pokémon list. {0}.
        /// </summary>
        internal static string ERR_POKEMON_LIST {
            get {
                return ResourceManager.GetString("ERR_POKEMON_LIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown Reddit category.
        /// </summary>
        internal static string ERR_REDDIT_UNKNOWN_CAT {
            get {
                return ResourceManager.GetString("ERR_REDDIT_UNKNOWN_CAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error updating Steam games list. {0}.
        /// </summary>
        internal static string ERR_STEAM_LIST {
            get {
                return ResourceManager.GetString("ERR_STEAM_LIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error updating TF2 item schema. {0}.
        /// </summary>
        internal static string ERR_TF2_LIST {
            get {
                return ResourceManager.GetString("ERR_TF2_LIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://{0}.com/api/frames/{1}/{2}/3000/4000.
        /// </summary>
        internal static string URL_GIFS_Frames {
            get {
                return ResourceManager.GetString("URL_GIFS_Frames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://{0}.com/api/random.
        /// </summary>
        internal static string URL_GIFS_Random {
            get {
                return ResourceManager.GetString("URL_GIFS_Random", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://{0}.com/gif/{1}/{2}/{3}.gif.
        /// </summary>
        internal static string URL_GIFS_Result {
            get {
                return ResourceManager.GetString("URL_GIFS_Result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.reddit.com/r/{0}/{1}.rss.
        /// </summary>
        internal static string URL_Reddit {
            get {
                return ResourceManager.GetString("URL_Reddit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.youtube.com/channel/{0}.
        /// </summary>
        internal static string URL_YouTube_Channel {
            get {
                return ResourceManager.GetString("URL_YouTube_Channel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.youtube.com/playlist?list={0}.
        /// </summary>
        internal static string URL_YouTube_Playlist {
            get {
                return ResourceManager.GetString("URL_YouTube_Playlist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.youtube.com/watch?v={0}.
        /// </summary>
        internal static string URL_YouTube_Video {
            get {
                return ResourceManager.GetString("URL_YouTube_Video", resourceCulture);
            }
        }
    }
}
