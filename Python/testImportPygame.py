import pygame

# Initialize Pygame
pygame.init()
screen = pygame.display.set_mode((600, 400))
pygame.display.set_caption("RC Robot Simulation")

# Colors
WHITE = (255, 255, 255)
BLUE = (0, 255, 225)

# Robot properties
robot_size = 40
x, y = 300, 200
speed = 5

# Main loop
running = True
clock = pygame.time.Clock()

while running:
    screen.fill(WHITE)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    keys = pygame.key.get_pressed()

    if keys[pygame.K_UP]:
        y -= speed
    elif keys[pygame.K_DOWN]:
        y += speed
    elif keys[pygame.K_LEFT]:
        x -= speed
    elif keys[pygame.K_RIGHT]:
        x += speed

    # Draw robot
    pygame.draw.rect(screen, BLUE, (x, y, robot_size, robot_size))

    pygame.display.flip()
    clock.tick(30)

pygame.quit()