import pyautogui
import time
import myfunc as mf

'''
    1. 그림판 실행 (win r)  입력 mspaint
    2. 흰영역 아무곳에 글자 입력 "참 잘했어요"
'''

pyautogui.hotkey('win','r')
pyautogui.write('mspaint')
pyautogui.hotkey('enter')

time.sleep(2)

window = pyautogui.getWindowsWithTitle('제목 없음 - 그림판')[0]
window.maximize()

box = pyautogui.locateOnScreen('font.PNG')
pyautogui.click(box)

pyautogui.move(0,200,duration=2)
pyautogui.click()

time.sleep(1)
mf.han_write('참 잘했어요')

time.sleep(3)
window.close()

time.sleep(2)
pyautogui.hotkey('n')
