'''
    1. 그림판 실행 (win r)  입력 mspaint
    2. 흰영역 아무곳에 글자 입력 "참 잘했어요"
'''

import pyautogui
import time
import pyperclip

pyautogui.hotkey('win','r')
pyautogui.write('mspaint')
pyautogui.hotkey('enter')

time.sleep(1)
file_a = pyautogui.locateOnScreen('text.PNG')
pyautogui.click(file_a)
pyautogui.click(250,400)

pyperclip.copy('참 잘했어요') 
pyautogui.hotkey('ctrl','v')
pyautogui.click(300,450)


