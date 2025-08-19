# Cloud fundamentals - AWS services for csharp developers.

**DynamoDB**
\
\
Is one of those services that can be extremely cheap for high scale but can also be
extremely expensive if you don't treat it correctly. So here's a few just small tips for us:

1. You're being charged on the size of your documents so smaller attribute names can reduce cost 
because reduce the size of the document itself.
2. Never ever ever try to store a file in DynamoDB. Just don't do that, we have S3 for that. :)
3. Always prefer queries over scans and prefer point reads over both of them. Don't do scans unless 
there is nothing else you can do and it's like a one off thing that you really need to do. Scans 
should be effectively prohibited.
4. Try to avoid strongly consistent reads and transactions as much as possible. We can use both 
if we want to but we'll save a lot of money just because the operations can be a two x and a four x 
on the original operational cost. So try to play around with it and see what you can afford for your
use case.
5. Be extremely careful with LSIs and GSIs. Good data modeling usually prevents the need to have a GSI 
and LSI. 
6. Use on demand capacity only if you really need it especially on those unpredictable spiky scenarios
or when you don't exactly know what your throughput is going to be. Are you trying to see how your application
performs during the day? And also if you can, consider looking into reserve capacity where you can reserve
a specific amount of capacity for maybe a year and you're gonna get up to fifty percent or more of discount
if you do that.
\
\
\
This is one of many projects to following allong a Dometrain course. 
This course was fully sponsord by AWS, meaning you can enroll it for free and the course is yours to keep and complete.
\
<sub>[Check it out here](https://dometrain.com/course/cloud-fundamentals-aws-services-for-c-developers)</sub>
