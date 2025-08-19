using Amazon.S3;
using Amazon.S3.Model;
using System.Text;

internal class GetRequest
{
    internal async Task Get(AmazonS3Client s3Client)
    {
        var getObjectRequest = new GetObjectRequest
        {
            BucketName = "ricardo0605awscourse",
            Key = "files/movies.csv"
        };

        var response = await s3Client.GetObjectAsync(getObjectRequest);

        using var memoryStream = new MemoryStream();
        response.ResponseStream.CopyTo(memoryStream);

        var text = Encoding.Default.GetString(memoryStream.ToArray());

        Console.Write(text);
    }
}