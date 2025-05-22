
# Users Request

## Structure

`UsersRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Username` | `string` | Optional | User's username |
| `Age` | `int` | Required | User's age |
| `IsActive` | `bool?` | Optional | Whether the user is active |
| `Rating` | `double?` | Optional | User's rating |
| `SignupDate` | `DateTime` | Required | Signup date |

## Example (as JSON)

```json
{
  "username": "username4",
  "age": 140,
  "isActive": false,
  "rating": 194.34,
  "signupDate": "2016-03-13"
}
```

