# API

```csharp
APIController aPIController = client.APIController;
```

## Class Name

`APIController`

## Methods

* [Getusers](../../doc/controllers/api.md#getusers)
* [Createanewuser](../../doc/controllers/api.md#createanewuser)


# Getusers

Returns a list of users, optionally filtered by search.

```csharp
GetusersAsync(
    string search = null,
    int? limit = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `search` | `string` | Query, Optional | Filter users by search term |
| `limit` | `int?` | Query, Optional | Limit the number of users returned |

## Response Type

[`Task<List<Models.UsersResponse>>`](../../doc/models/users-response.md)

## Example Usage

```csharp
try
{
    List<UsersResponse> result = await aPIController.GetusersAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Createanewuser

Creates a user with default values if not provided.

```csharp
CreateanewuserAsync(
    Models.UsersRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UsersRequest`](../../doc/models/users-request.md) | Body, Required | - |

## Response Type

[`Task<Models.UsersResponse1>`](../../doc/models/users-response-1.md)

## Example Usage

```csharp
UsersRequest body = new UsersRequest
{
    Age = 2,
    SignupDate = DateTime.Parse("2016-03-13"),
};

try
{
    UsersResponse1 result = await aPIController.CreateanewuserAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

