# CrazyCar

# 세부 설명

## PlayerPrefs
Session간 데이터를 유지하기 위해 사용합니다. 또는 재실행 시 데이터를 가져올 때 사용됩니다.<br>
제가 문제를 겪었던 이유는 PlayerPrefs.SetInt(...)를 하고 PlayerPrefs.save()를 통해 <br>
해당 Prefs를 저장하지 않았던 것이 큰 이유였습니다.<br>
