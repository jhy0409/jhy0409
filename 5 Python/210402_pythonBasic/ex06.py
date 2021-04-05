import pyautogui
import time
import pyperclip

time.sleep(2)

pyautogui.hotkey('win','r')
pyautogui.write('notepad')
pyautogui.hotkey('enter')

time.sleep(1)
pyautogui.write('12345')
pyautogui.write('abcde', interval=0.25)

pyperclip.copy('한글 입력') 
pyautogui.hotkey('ctrl','v')


'''
    긴 주석달기
    moveTo mouseDown mouseUp locateOnScreen click
    pyautogui 클릭... 마우스 조작 키보드 조작 라이브러리
    Pillow 이미지 사용 라이브러리

    matplotlb 그래프 그리는 라이브러리 *
    numpy 데이터 사용 라이브러리 *
    * : 인공지능 라이브러리
'''