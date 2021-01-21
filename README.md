# FitnessFrogApi

NOTES
 
REST APIs are composed of "resources", which are the things that we want to retrieve, create, or modify through the API.

REST API resources are represented by Uniform Resource Identifiers—or URIs. These URIs or "endpoints" represent either a collection of records or a single record.

MAIN HTTP Methods -

GET: Fetchs a collection or single resource.
POST: Adds new resource to collection.
PUT: Updates a resource.
DELETE: Deletes a resource.

REST APIs expect that state is being maintained on the client. Storing state on the client reduces overhead on the server, allowing the server to service more requests.

Each response that is returned by a REST API includes a Status header which is used to tell the client the result of the request using standard HTTP response status codes. 

HTTP response status codes are organized into four blocks: the 200's, 300's, 400's, and 500's.

--------------------------------------------------------------

Even though Web API isn't part of ASP.NET MVC, there are similarities between the two frameworks, including routing, controllers, and action methods.

Web API was built around the HTTP protocol and its messaging semantics which allows it to embrace the conventions of REST.

Because of this, it's easy to create APIs that expose resource focused endpoints and associate controller action methods with specific HTTP methods.

When a client makes a request to our API, Web API uses the "resource name" to determine which API controller to instantiate. 

This style of routing is known as convention-based routing. Another form of routing, attribute routing, can also be used, but isn't covered in this course.

Web API uses the request's HTTP method to determine which action method on the controller to call.

Web API—by default—will look for a controller action method whose name matches or starts with the HTTP method name. This convention can overridden by decorating action methods with HTTP method attributes.

Prefixing routes with "api" when using Web API helps to ensure that API routes won't collide with any ASP.NET MVC routes.

--------------------------------------------------------------
