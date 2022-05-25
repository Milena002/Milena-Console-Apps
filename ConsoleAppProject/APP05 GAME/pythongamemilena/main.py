# importing libraries needed for this game
import pygame
import math
import random
# library for the sound in the game
from pygame import mixer

# declare the pygame
pygame.init()

# Create the screen for Hansel and Gretel game
screen = pygame.display.set_mode((800, 600))

# Forest background for the Hansel and Gretel game
background = pygame.image.load('forest3.png')

# Sound - I've choosen adventure type music
mixer.music.load("music1.mp3")
mixer.music.play(-1)

# Caption and Icon for this game
pygame.display.set_caption("Hansel and Gretel")
icon = pygame.image.load('forest.png')
pygame.display.set_icon(icon)

# Player - Gretel
playerImg = pygame.image.load('girl.png')
playerX = 370
playerY = 480
playerX_change = 0

# Baba - Yaga(s)
witchImg = []
witchX = []
witchY = []
witchX_change = []
witchY_change = []
num_of_witches = 6
 # generating the witches
for i in range(num_of_witches):
    witchImg.append(pygame.image.load('witch.png'))
    witchX.append(random.randint(0, 736))
    witchY.append(random.randint(50, 150))
    witchX_change.append(4)
    witchY_change.append(40)

# Hearts - In my game the player need to shoot a Baba Yaga by hearts(love)

# status ready for prepare, status fire heart in motion

#shooting by hearts to Baba Yaga(s) and getting points for that
heartImg = pygame.image.load('heart.png')
heartX = 0
heartY = 480
heartX_change = 0
heartY_change = 10
heart_state = "ready"

# Score of shooting the Baba Yaga, score starting from zero and increase if shoot is great
score_value = 0
font = pygame.font.Font('freesansbold.ttf', 32)

textX = 10
testY = 10

# Game Over - if Baba Yaga will 'touch' the player.
# declaring fonts for messaging
over_font = pygame.font.Font('freesansbold.ttf', 90)
over_font1 = pygame.font.Font('freesansbold.ttf', 40)

# showing score for the game - if better score, you are better player!
def show_score(x, y):
    score = font.render("Score : " + str(score_value), True, (255, 255, 255))
    screen.blit(score, (x, y))

#Game over text banner:
def over_text():
    over_text = over_font.render("Game over!", True, (255, 255, 255))
    screen.blit(over_text, (140, 250))
# Text about quiting the game:
def quit_text():
    quit_text = over_font1.render("Click backspace to quit the game.", True, (255, 0, 0))
    screen.blit(quit_text, (90,400))



# declare the player - in that case Gretel
def player(x, y):
    screen.blit(playerImg, (x, y))

# declare the witch[] - because we want more than one witch in the game
def witch(x, y, i):
    screen.blit(witchImg[i], (x, y))

# declaring shooting heart and its position
def fire_heart(x, y):
    global heart_state
    heart_state = "fire"
    screen.blit(heartImg, (x + 16, y + 10))

# finding the correct space to shoot
def isCollision(witchX, witchY, heartX, heartY):
    distance = math.sqrt(math.pow(witchX - heartX, 2) + (math.pow(witchY - heartY, 2)))
    if distance < 27:
        return True
    else:
        return False


# Game Loop
running = True
while running:

    # RGB = Red, Green, Blue
    screen.fill((0, 0, 0))
    # Background Image
    screen.blit(background, (0, 0))
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

        # checking keystroke if its right or left
        if event.type == pygame.KEYDOWN:
# moving right or left in the forest
            if event.key == pygame.K_LEFT:
                playerX_change = -5
            if event.key == pygame.K_RIGHT:
                playerX_change = 5
# if clicking a space - shooting to the Baba Yaga
            if event.key == pygame.K_SPACE:
                if heart_state == "ready":
                    # location of baba Yaga
                    witchSound = mixer.Sound("shoot.wav")
                    witchSound.play()
                    heartX = playerX
                    fire_heart(heartX, heartY)
# at the end of game if we will click backspace - quit game
            if event.key == pygame.K_BACKSPACE:
                pygame.quit()


        if event.type == pygame.KEYUP:
            if event.key == pygame.K_LEFT or event.key == pygame.K_RIGHT:
                playerX_change = 0
# position of player
    playerX += playerX_change
    if playerX <= 0:
        playerX = 0
    elif playerX >= 736:
        playerX = 736

    # Witches Movement
    for i in range(num_of_witches):

        # Game Over
        if witchY[i] > 440:
            for j in range(num_of_witches):
                witchY[j] = 2000
            over_text()
            gameoverSound = mixer.Sound("gameover.wav")
            gameoverSound.play()
            quit_text()


            break
    # witch movemont
        witchX[i] += witchX_change[i]
        if witchX[i] <= 0:
            witchX_change[i] = 4
            witchY[i] += witchY_change[i]
        elif witchX[i] >= 736:
            witchX_change[i] = -4
            witchY[i] += witchY_change[i]

        # Collision
        collision = isCollision(witchX[i], witchY[i], heartX, heartY)
        if collision:
            explosionSound = mixer.Sound("death.mp3 ")
            explosionSound.play()
            heartY = 480
            heart_state = "ready"
            score_value += 1
            witchX[i] = random.randint(0, 736)
            witchY[i] = random.randint(50, 150)

        witch(witchX[i], witchY[i], i)

    # haert shooting Movement
    if heartY <= 0:
        heartY = 480
        heart_state = "ready"

    if heart_state == "fire":
        fire_heart(heartX, heartY)
        heartY -= heartY_change

    player(playerX, playerY)
    show_score(textX, testY)
    pygame.display.update()
