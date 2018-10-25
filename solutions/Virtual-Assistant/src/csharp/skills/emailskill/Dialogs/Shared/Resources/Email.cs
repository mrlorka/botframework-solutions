// <auto-generated>
// Code generated by LUISGen .\Desktop\0.13.1 (1).json -cs Luis.Email -o .\Desktop
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Luis
{
    public class Email: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            AddFlag, 
            CheckMessages, 
            Confirm, 
            ConfirmNo, 
            Forward, 
            None, 
            QueryLastText, 
            ReadAloud, 
            Reply, 
            SearchMessages, 
            SelectItem, 
            SendEmail, 
            ShowNext, 
            ShowPrevious,
            Delete
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Attachment;
            public string[] Category;
            public string[] ContactName;
            public string[] Date;
            public string[] EmailAddress;
            public string[] EmailPlatform;
            public string[] EmailSubject;
            public string[] FromRelationshipName;
            public string[] Line;
            public string[] Message;
            public string[] OrderReference;
            public string[] PositionReference;
            public string[] RelationshipName;
            public string[] SearchTexts;
            public string[] SenderName;
            public string[] Time;

            // Built-in entities
            public DateTimeSpec[] datetime;
            public double[] number;
            public double[] ordinal;

            // Instance
            public class _Instance
            {
                public InstanceData[] Attachment;
                public InstanceData[] Category;
                public InstanceData[] ContactName;
                public InstanceData[] Date;
                public InstanceData[] EmailAddress;
                public InstanceData[] EmailPlatform;
                public InstanceData[] EmailSubject;
                public InstanceData[] FromRelationshipName;
                public InstanceData[] Line;
                public InstanceData[] Message;
                public InstanceData[] OrderReference;
                public InstanceData[] PositionReference;
                public InstanceData[] RelationshipName;
                public InstanceData[] SearchTexts;
                public InstanceData[] SenderName;
                public InstanceData[] Time;
                public InstanceData[] datetime;
                public InstanceData[] number;
                public InstanceData[] ordinal;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public virtual _Entities Entities { get; set; }

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<Email>(JsonConvert.SerializeObject(result));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public virtual (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = (double)entry.Value.Score;
                }
            }
            return (maxIntent, max);
        }
    }
}
