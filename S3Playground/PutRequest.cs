using Amazon;
using Amazon.S3;
using Amazon.S3.Model;

namespace S3Playground;
internal class PutRequest
{
    internal async Task Put(AmazonS3Client s3Client)
    {
        var files = new List<(string, string, string)>()
        {
            new ("images", "./face.jpg", "image/jpeg"),
            new ("files", "./movies.csv", "text/csv")
        };

        foreach (var file in files)
        {
            using var inputStream = new FileStream(file.Item2, FileMode.Open, FileAccess.Read);

            var putObejectRequest = new PutObjectRequest
            {
                BucketName = "ricardo0605awscourse",
                Key = $"{file.Item1}/{file.Item2.Replace("./", "")}",
                ContentType = file.Item3,
                InputStream = inputStream
            };

            await s3Client.PutObjectAsync(putObejectRequest);
        }
    }
}
