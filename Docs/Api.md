# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "firstName": "Fuzuli",
  "lastName": "Hameed",
  "email": "fhameed@dotnetcorecompany.com",
  "password": "fhameed4321!"
}
```

#### Register Response

```js
200 OK
```

```json
{
  "id": "d78c8d9d-e83u-4075-85ff-a475a55bb140",
  "firstName": "Fuzuli",
  "lastName": "Hameed",
  "email": "fuzulihameed@gmail.com",
  "token": "fhXcu..hbaL"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
  "email": "fhameed@dotnetcorecompany.com",
  "password": "fhameed4321!"
}
```

#### Login Response

```js
200 OK
```

```json
{
  "id": "d78c8d9d-e83u-4075-85ff-a475a55bb140",
  "firstName": "Fuzuli",
  "lastName": "Hameed",
  "email": "fuzulihameed@gmail.com",
  "token": "fhJhb..hbaQ"
}
```
