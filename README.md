# Example .NET Core app using CQ(R)S with Dapper


> **Note: This is just an example for education purposes - if you want CQ(R)S that works quite nicely out of the box - you should look at [Jimmy Bogard's MediatR](https://github.com/jbogard/MediatR)**

This small .NET Solution shows how to implement CQS pattern with good separation of concerns.

Some of the advantages of using a solution like this instead of other ways of implementing the pattern are:
- No GOD command and query objects
- Easy dependency injection
- Only ONE component is needed to be injected and used to execute ANY command
- Only ONE component is needed to be injected nad used to execute ANY query

## Main Components

We have SIX main components that allow us to do all of this.

todo: add class diagram

### CommandsProcessor

todo

### CommandHandler

todo

### Command DTO

todo

### QueriesProcess

todo

### QueryHandler

todo

### Query DTO

todo
