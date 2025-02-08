# 问题记录 Question

- **Github Actions**
  - 因为 "NerdBank.GitVersioning" 导致构建失败

    ```powershell
    Nerdbank.GitVersioning.GitException: Shallow clone lacks the objects required to calculate version height. Use full clones or clones with a history at least as deep as the last version height resetting change.
    ```

    - 解决方案

    ```yml
    name: .NET Build On Windows
    on:
      push:
        branches: [ "dev" ]
      pull_request:
        branches: [ "dev" ]
    
    jobs:
      build:
    
        runs-on: windows-latest
    
        steps:
        - uses: actions/checkout@v4
          with:
            fetch-depth: 0 # 关注此行。参考文献：https://dotnet.github.io/Nerdbank.GitVersioning/docs/cloudbuild.html
        - name: Setup .NET
          uses: actions/setup-dotnet@v4
          with:
            dotnet-version: 9.0.x
        - name: Restore dotnet tools
          run: dotnet tool restore
        - name: Restore dependencies
          run: dotnet restore ./src
        - name: Build
          run: dotnet build ./src -c Release --no-restore
    ```
    
  