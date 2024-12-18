# 아두이노 초음파 센서를 활용한 2D 맵핑 프로젝트

이 프로젝트는 **아두이노 UNO**, **초음파 센서 (HC-SR04)**, 그리고 **서보 모터 (SG90)**를 사용하여 주변 환경을 2D로 맵핑하는 시스템입니다.  
측정된 데이터는 **C# GUI 프로그램**을 통해 실시간으로 시각화됩니다.

---

## 🚀 **프로젝트 주요 기능**
1. **거리 측정**: 초음파 센서를 이용해 거리 데이터를 수집합니다.  
2. **각도 제어**: 서보 모터를 회전시켜 다양한 각도에서 데이터를 측정합니다.  
3. **시리얼 통신**: 아두이노에서 수집한 데이터를 PC로 전송합니다.  
4. **실시간 시각화**: C# GUI 프로그램에서 데이터를 기반으로 맵을 그립니다.  

---

## 📂 **소스 코드 구조**

```
.
├── README.md
├── arduino/                # 아두이노 코드
│   ├── Miconproject.ino    # 메인 코드
│   ├── Sensor.cpp          # 초음파 센서 제어
│   ├── Sensor.h
│   ├── Wiper.cpp           # 서보 모터 제어
│   └── Wiper.h
└── gui/                    # C# GUI 코드
    ├── Form1.cs            # GUI 메인 코드
    ├── SPort.cs            # 시리얼 통신
    ├── TCanvas.cs          # 시각화 클래스
    ├── servo.csproj        # 프로젝트 설정 파일
    └── servo.sln           # Visual Studio 솔루션 파일
```

---

## 🛠️ **실행 방법**

### **1. 하드웨어**
- **초음파 센서**: TRIG → 3번 핀, ECHO → 2번 핀  
- **서보 모터**: 신호선 → 11번 핀  

### **2. 아두이노 코드 업로드**
1. **Arduino IDE**를 열고 `arduino/Miconproject.ino` 파일을 업로드합니다.  
2. 아두이노 보드를 PC와 연결합니다.

### **3. C# GUI 실행**
1. `gui/servo.sln` 파일을 **Visual Studio**에서 엽니다.  
2. 프로젝트를 빌드하고 실행합니다.  
3. 시리얼 포트를 설정한 후, **Start** 버튼을 눌러 데이터를 확인합니다.

---

## 블로그
[https://knowgyu.github.io/posts/%EC%95%84%EB%91%90%EC%9D%B4%EB%85%B8-%EC%B4%88%EC%9D%8C%ED%8C%8C-SLAM/](https://knowgyu.github.io/posts/%EC%95%84%EB%91%90%EC%9D%B4%EB%85%B8-%EC%B4%88%EC%9D%8C%ED%8C%8C-SLAM/)
