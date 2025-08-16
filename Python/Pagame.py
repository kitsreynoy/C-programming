import pygame

# Initialize Pygame
pygame.init()

# Create the window
screen = pygame.display.set_mode((400, 300))
pygame.display.set_caption("Pygame Live Demo")

# Player starting position
x, y = 50, 50

# Game loop control
running = True
clock = pygame.time.Clock()

# Game loop
while running:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    # Get pressed keys
    keys = pygame.key.get_pressed()
    if keys[pygame.K_LEFT]:
        x -= 5
    if keys[pygame.K_RIGHT]:
        x += 5
    if keys[pygame.K_UP]:
        y -= 5
    if keys[pygame.K_DOWN]:
        y += 5

    # Keep the square inside the window
    x = max(0, min(x, 350))
    y = max(0, min(y, 250))

    # Draw everything
    screen.fill((0, 0, 0))
    pygame.draw.rect(screen, (0, 255, 0), (x, y, 50, 50))
    pygame.display.flip()

    # Limit frame rate
    clock.tick(60)

# Quit Pygame
pygame.quit()
