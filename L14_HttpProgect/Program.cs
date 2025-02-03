namespace L14_HttpProgect
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://httpbin.org/";
            
            var client = new HttpMethod();
            var responseForGet = await client.GetContent(url);
            //Console.WriteLine(responseForGet);
            var responseForPost = await client.PostContent(url, "How are you?");
            Console.WriteLine(responseForPost);
            var responseForPut = await client.PutContent(url, "I'm fine");
            Console.WriteLine(responseForPut);
            var responseForDelete = await client.DeleteContent(url);
            Console.WriteLine(responseForDelete);

        }
    }
}
