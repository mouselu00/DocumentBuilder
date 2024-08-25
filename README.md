# DocumentBuilder

#NetCore 

套件：[dotnet/docfx: Static site generator for .NET API documentation. (github.com)](https://github.com/dotnet/docfx)
參考：[Quick Start | docfx (dotnet.github.io)](https://dotnet.github.io/docfx/index.html)

## 注意事項
1. 執行語法的時候要確定設定的檔案 `docfx.json`  說設定的掃描專案及來源是否正確，因為會覆蓋掉原本生成高的文檔資料

## 建立步驟
### 1. 安裝套件
```
dotnet tool update -g docfx
```

### 2.建立專案並初始化
```
docfx init
```

### 3. 配置文件
```json
{
  "metadata": [
    {
      "dest": "api",
      "properties": {
        "TargetFramework": "net8.0"
      },
      "src": [
        {
          "src": "./",
          "files": [
            "**/*.csproj"
          ]
        }
      ]
    }
  ],
  "build": {
    "content": [
      {
        "files": [
          "**/*.{md,yml}"
        ],
        "exclude": [
          "_site/**"
        ]
      }
    ],
    "resource": [
      {
        "files": [
          "images/**"
        ]
      }
    ],
    "output": "_site",
    "template": [
      "default",
      "default(zh-cn)",
      "modern"
    ],
    "globalMetadata": {
      "_appName": "",
      "_appTitle": "",
      "_enableSearch": true,
      "pdf": true
    }
  }
}

```
其中 `metadata` 的設定較為重要：
```json
"metadata": [
    {
      "dest": "api", // 生成文檔的導覽路徑
      "properties": { // 屬性，可以指定版本
        "TargetFramework": "net8.0"
      },
      "src": [ // 來源
        {
          "src": "./", // 來源路徑，目前是指向當下路徑下
          "files": [   // 掃描的資源
            "**/*.csproj"
          ]
        }
      ]
    }

```

> 也可參考官網針對`.NET`提供的範例設定 : [.NET API Docs | docfx (dotnet.github.io)](https://dotnet.github.io/docfx/docs/dotnet-api-docs.html)

### 4.生成後的網站
執行指令
```
docfx --server
```

## 語系
目前還沒有辦法生成繁體中文，只有簡體中文：
```json
// docfx.json
"template": [
      "default",
      "default(zh-cn)",  // 簡體中文
      "modern"
    ],

```


## 參考來源
- [使用DocFX构建API Web文档 - Memoyu - 博客园 (cnblogs.com)](https://www.cnblogs.com/memoyu/p/16896265.html)