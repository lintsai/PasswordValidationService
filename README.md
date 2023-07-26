# Password Validation Service

## Instructions

* 必須僅由小寫字母和數字組成，並且至少有一個
每個。
* 長度必須介於 5 到 12 個字符之間。
* 不得包含任何緊跟相同序列的字符序列。

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
