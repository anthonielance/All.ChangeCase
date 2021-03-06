# All.ChangeCase

Ported: https://github.com/soltys/Soltys.ChangeCase to .NET Standared 2.0

## Usage
Add using:
```csharp
  using All.ChangeCase
```

Sample usage:
```csharp
  string camelCase = "test string".CamelCase() // camelCase => testString
```

### SentenceCase()

```csharp
  string input = null;
  input.SentenceCase() //=> ""
  "string".SentenceCase(); //=> string
  "dot.case".SentenceCase(); //=> dot case
  "camelCase".SentenceCase(); //=> camel case
  "HELLO WORLD!".SentenceCase("_"); //=> hello_world
  "A STRING".SentenceCase(ci: CultureInfo.CreateSpecificCulture("tr")); //=> a strıng
```

### CamelCase()

```csharp
  string input = null;
  input.CamelCase() //=> ""
  "string".CamelCase(); //=> string
  "dot.case".CamelCase(); //=> dotCase
  "PascalCase".CamelCase(); //=> pascalCase
  "version 1.2.10".CamelCase(); //=> version1_2_10
  "STRING 1.2".CamelCase(ci: CultureInfo.CreateSpecificCulture("tr")); //=> strıng1_2
```

### PascalCase()

```csharp
  string input = null;
  input.PascalCase() //=> ""
  "string".PascalCase(); //=> String
  "dot.case".PascalCase(); //=> DotCase
  "camelCase".PascalCase(); //=> CamelCase
```

### UpperCaseFirst()

```csharp
  string input = null;
  input.UpperCaseFirst() //=> ""
  "string".UpperCaseFirst() //=> "String"
```

### LowerCaseFirst()

``` csharp
string input = null;
input.LowerCaseFirst() //=> ""
"STRING".LowerCaseFirst() //=> "sTRING"
```

### ParamCase()

```csharp
  string input = null;
  input.ParamCase() //=> ""
  "string".ParamCase(); //=> string
  "sentance case".ParamCase(); //=> sentance-case
  "camelCase".ParamCase(); //=> camel-case
```

### DotCase()

```csharp
  string input = null;
  input.DotCase() //=> ""
  "string".DotCase(); //=> string
  "sentance case".DotCase(); //=> sentance.case
  "camelCase".DotCase(); //=> camel.case
```

### SwapCase()

```csharp
  string input = null;
  input.SwapCase() //=> ""
  "string".SwapCase(); //=> STRING
  "PascalCase".SwapCase(); //=> pASCALcASE
  "Iñtërnâtiônàlizætiøn".SwapCase(); //=> iÑTËRNÂTIÔNÀLIZÆTIØN
```

### TitleCase()

```csharp
  string input = null;
  input.TitleCase() //=> ""
  "string".TitleCase(); //=> String
  "sentance case".TitleCase(); //=> Sentance Case
  "camelCase".TitleCase(); //=> Camel Case
```

### SnakeCase()

```csharp
  string input = null;
  input.SnakeCase() //=> ""
  "string".SnakeCase(); //=> string
  "sentance case".SnakeCase(); //=> sentance_case
  "camelCase".SnakeCase(); //=> camel_case
```

### ConstantCase()

```csharp
  string input = null;
  input.ConstantCase() //=> ""
  "string".ConstantCase(); //=> STRING
  "sentance case".ConstantCase(); //=> SENTANCE_CASE
  "camelCase".ConstantCase(); //=> CAMEL_CASE
```

### HeaderCase()

```csharp
  string input = null;
  input.HeaderCase() //=> ""
  "string".HeaderCase(); //=> String
  "sentance case".HeaderCase(); //=> Sentance-Case
  "camelCase".HeaderCase(); //=> Camel-Case
```
