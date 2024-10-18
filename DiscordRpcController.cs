using DiscordRPC;
using Button = DiscordRPC.Button;


public class DiscordRpcController
{
    public static string currentDetails,
        currentState,
        currentLargeImageKey,
        currentSmallImageKey,
        currentLargeImageText,
        currentSmallImageText,
        currentButton1Text,
        currentButton1Url,
        currentButton2Text,
        currentButton2Url;
    public static DateTime currentStartTime, currentEndTime;

    private static readonly DiscordRpcClient client = new("1265511577818366066");
    public DiscordRpcController()
    {

        currentDetails = "Placeholder";
        currentState = "Placeholder";
        currentLargeImageKey = "https://external-preview.redd.it/Jg0DWmCkKcB1KA3qETpEGBaBfVlrN9eMKwhWLs52VpI.jpg?width=640&crop=smart&auto=webp&s=208d0d7dd99d40f9f368054e90603bf48fcfda09";
        currentSmallImageKey = "https://matthasanopinion.com/wp-content/uploads/2022/01/hollow-knight-bosses.jpg?w=1024";
        currentLargeImageText = "Natsuki, cry about it";
        currentSmallImageText = "The best fucking boss";
        currentStartTime = DateTime.UtcNow;
        currentEndTime = DateTime.UtcNow;
        currentButton1Text = "One button";
        currentButton1Url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        currentButton2Text = "Two buttons";
        currentButton2Url = "https://www.twitch.tv/vegetta777";

        client.Initialize();
        UpdateRpc(false);
    }

    public static void UpdateRpc(bool usingEndTime)
    {
        var presenceNoEnd = new RichPresence()
        {
            Details = currentDetails,
            State = currentState,
            

            Assets = new Assets()
            {
                LargeImageKey = currentLargeImageKey,
                LargeImageText = currentLargeImageText, 

                SmallImageKey = currentSmallImageKey,
                SmallImageText = currentSmallImageText
            },

            Timestamps = new Timestamps()
            {
                Start = currentStartTime
                
            },

            Buttons = new[]
            {
                new Button()
                {
                    Label = currentButton1Text,
                    Url = currentButton1Url
                },
                new Button() 
                {
                    Label = currentButton2Text,
                    Url = currentButton2Url
                }
            }
        };

        var presenceEnd = new RichPresence()
        {
            Details = currentDetails,
            State = currentState,


            Assets = new Assets()
            {
                LargeImageKey = currentLargeImageKey,
                LargeImageText = currentLargeImageText,

                SmallImageKey = currentSmallImageKey,
                SmallImageText = currentSmallImageText
            },

            Timestamps = new Timestamps()
            {
                Start = currentStartTime,
                End = currentEndTime

            },

            Buttons = new[]
            {
                new Button()
                {
                    Label = currentButton1Text,
                    Url = currentButton1Url
                },
                new Button()
                {
                    Label = currentButton2Text,
                    Url = currentButton2Url
                }
            }
        };

        if (usingEndTime)
        {
            client.SetPresence(presenceEnd);
        }
        else
        {
            client.SetPresence(presenceNoEnd);   
        }
    }


    #region GETTERS

    public static string GetState()
    {
        return client.CurrentPresence.State;
    }

    public static string GetDetails()
    {
        return client.CurrentPresence.Details;
    }

    public static string GetLargeImageKey()
    {
        return client.CurrentPresence.Assets.LargeImageKey;
    }

    public static string GetLargeImageText()
    {
        return client.CurrentPresence.Assets.LargeImageText;
    }

    public static string GetSmallImageKey()
    {
        return client.CurrentPresence.Assets.SmallImageKey;
    }

    public static string GetSmallImageText()
    {
        return client.CurrentPresence.Assets.SmallImageText;
    }

    public static string GetStartTime()
    {
        return client.CurrentPresence.Timestamps.Start.ToString() ?? DateTime.UtcNow.ToString();
    }

    public static string GetButton1Text()
    {
        return client.CurrentPresence.Buttons[0].Label;
    }

    public static string GetButton1Url()
    {
        return client.CurrentPresence.Buttons[0].Url;
    }

    public static string GetButton2Text()
    {
        return client.CurrentPresence.Buttons[1].Label;
    }

    public static string GetButton2Url()
    {
        return client.CurrentPresence.Buttons[1].Url;
    }

    #endregion
}