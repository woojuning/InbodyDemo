# Inbody Demo Application
<img src = "https://github.com/woojuning/InbodyDemo/assets/86952133/87cd947c-ec71-4388-a30e-ecb3bda3ef15" width = "80%" height = "80%">



![Home](https://github.com/woojuning/InbodyDemo/assets/86952133/3cb9b514-2032-421c-8261-4a8d8e2ad798)

## 사용 기술
1. Visual Studio 2022
2. C#, Winform
3. Dapper Lib, MSSQL

## 프로젝트 소개
- 헬스장에서 측정할 수 있는 인바디를 Desktop Application으로 데모 프로그램을 만들었습니다.
- Winform을 사용했습니다. 특히 UserControl을 활용하여 Event를 통해 화면간 통신을 구현했습니다.
- 실제 하드웨어에서 데이터를 받아오지 못해 서버를 만들어서 데이터를 요청했습니다.

## 구현내용
1. Home
    - 회원번호를 입력하면 데이터베이스에서 이전 데이터를 차트로 표현해준다.
2. Analysis
    - 헬스장에서 사용한 인바디 측정 화면을 구현했다.
    - 서버로 부터 설정한 몸무게, 체지방량, 근육량을 가져온다.
    - 타이머를 활용해 애니메이션 UI를 구현했다.
    - 측정 완료 후 DB에 저장한다.

## Home
<img src = "https://github.com/woojuning/InbodyDemo/assets/86952133/d2009f9e-be1f-4b02-8fa9-372e911666f2" width = "80%" height = "80%">

- 기본 Chart Control을 활용해서 

