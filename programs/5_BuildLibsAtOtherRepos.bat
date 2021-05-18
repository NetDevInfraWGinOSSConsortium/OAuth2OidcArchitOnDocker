@echo off

@rem 本バッチファイルの作成にあたり、以下のサイトを参考にしました。
@rem 【Bat】【vim】香り屋Vimをダウンロードしてインストールまでするbatファイル - Qiita
@rem https://qiita.com/koryuohproject/items/beed1a28ad6a1f60256d

setlocal

@rem ZIPファイル名
set zipfilename=Temp3.zip

@rem GitHubのZIPパス
set branchName=01-20
set srcUrl=https://github.com/OpenTouryoProject/ResourceServerTemplates/archive/%branchName%.zip

@rem 解凍ディレクトリ
set extDir=%CD%

@rem 一時ディレクトリ
set tmpDir=Temp3

:Download
@rem ダウンロードされたZIPファイルがあるなら解凍
if exist %extDir%\%zipfilename% GOTO Extract

@rem ZIPファイルのダウンロード
@powershell -NoProfile -ExecutionPolicy Bypass -Command "$d=new-object System.Net.WebClient; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.SecurityProtocolType]::Tls12; $d.Proxy.Credentials=[System.Net.CredentialCache]::DefaultNetWorkCredentials; $d.DownloadFile('%srcUrl%','%extDir%/%zipfilename%')"

:Extract
@rem 解凍フォルダがあるならコピー
if exist %extDir%\%tmpDir% GOTO Copy
@rem ZIPファイルを一時ディレクトリに解凍
@powershell -NoProfile -ExecutionPolicy Bypass -Command "expand-archive %zipfilename%"

@rem プロジェクトをコピー
:Copy
cd %extDir%
xcopy /Y /E "Temp3\ResourceServerTemplates-%branchName%\root\programs\WS_sampleCore\WSIFType_sample" "WSIFType_sample\"
xcopy /Y /E "Temp3\ResourceServerTemplates-%branchName%\root\programs\WS_sampleCore\WSServer_sample" "WSServer_sample\"
