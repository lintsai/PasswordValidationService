# Password Validation Service

## Instructions

* 不得為全部連續字元。
* 長度必須介於 5 到 12 個字元之間。
* 必須僅由小寫字母和數位混合組成。

## Framework
* C#
* JavaScript
* Html

## API Spec
- requests to the /validator to check the password
```
/validator?password={input.value}
```
- response a json value
```
key=validation rules
value=true/false
```
- Example
```
https://localhost:7192/validator?password={input.value}
```

## Test Page
https://localhost:7192/

1. input "Enter Password"
2. check "Submit" button
3. "Valid" response PASS/FAIL
4. "Output" show full response
