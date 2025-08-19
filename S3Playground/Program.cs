using Amazon;
using Amazon.S3;
using S3Playground;

var s3Client = new AmazonS3Client(RegionEndpoint.USEast1);

await new PutRequest().Put(s3Client);
await new GetRequest().Get(s3Client);