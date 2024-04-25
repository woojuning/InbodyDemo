# Inbody Demo Application
<img src = "https://github.com/woojuning/InbodyDemo/assets/86952133/87cd947c-ec71-4388-a30e-ecb3bda3ef15" width = "100%" height = "100%">


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

## Menu Drawer
 - 기술 예정


## Home

![Home3](https://github.com/woojuning/InbodyDemo/assets/86952133/83a113c3-a0fa-4698-b8f4-2560ac181a33)

- 기본 Chart Control을 활용했다. 
- Charat Control의 여러 Event를 활용해 구현했다.

## Analysis

![Analysis2](https://github.com/woojuning/InbodyDemo/assets/86952133/12851c38-7dcc-4433-843c-d7d631e9c612)

- 각 화면을 UserControl로 만들었다.
- EventHandler를 활용하여 UserControl간 통신을 하였다.
- 
