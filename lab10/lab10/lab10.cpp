#include "glut.h"

void display() {
	glClear(GL_COLOR_BUFFER_BIT);
	//Teapot
	glutWireTeapot(.5);
	glFlush();
}

void klawiatura(unsigned char key, int x, int y)
{
	switch (key)
	{
	case 27:
	case 'q':
		exit(0);
		break;
	case 'o':
		glOrtho(-2.0, 2.0, -2.0, 2.0, -2.0, 2.0);
		gluLookAt(1.0, 1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		break;
	case 'p':
		glFrustum(-1.0, 1.0, -1.0, 1.0, 1.0, 3.0);
		gluLookAt(1.0, 1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		break;
	case '1':
		gluLookAt(0.0, 0.0, 0.0, 0.1, -0.2, 0.1, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		break;
	case '2':
		gluLookAt(0.0, 0.0, 0.0, 0.1, 0.1, 0.1, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		break;
	case '3':
		gluLookAt(0.0, 0.0, 0.0, -0.1, -0.1, -0.1, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		break;
	case 'r': 
		glRotatef(0.5, 0.5, 0.5, 0.5);
		glutPostRedisplay();
		break;
	case 't':
		glTranslatef(0.1, 0.1, 0.1);
		glutPostRedisplay();
		break;
	case 's':
		glScalef(0.9, 0.9, 0.9);
		glutPostRedisplay();
		break;

	}
}

bool isPset = 0;

void keyboardSpecialKeys(int key, int x, int y) {
	switch (key) {
	case GLUT_KEY_UP:
		if (isPset == 0) {
			glFrustum(-1.0, 1.0, -1.0, 1.0, 1.0, 3.0);
			gluLookAt(1.0, 1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
			isPset = 1;
		}
		gluLookAt(0.0, 0.0, 0.1, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
		glutPostRedisplay();
	break;
	case GLUT_KEY_DOWN:
		if (isPset == 0) {
			glFrustum(-1.0, 1.0, -1.0, 1.0, 1.0, 3.0);
			gluLookAt(1.0, 1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
			isPset = 1;
		}
		gluLookAt(0.0, 0.0, -0.1, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		break;
	case GLUT_KEY_LEFT:
		if (isPset == 0) {
			glFrustum(-1.0, 1.0, -1.0, 1.0, 1.0, 3.0);
			gluLookAt(0.1, 1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
			isPset = 1;
		}
		gluLookAt(0.1, .0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		break;
	case GLUT_KEY_RIGHT:
		if (isPset == 0) {
			glFrustum(-1.0, 1.0, -1.0, 1.0, 1.0, 3.0);
			gluLookAt(.1, 1.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
			isPset = 1;
		}
		gluLookAt(-0.1, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0);
		glutPostRedisplay();
		break;
	}
}

int main(int argc, char* argv[])
{
	glutInit(&argc, argv);
	glutInitWindowSize(700, 700);
	glutInitWindowPosition(0, 0);
	glutInitDisplayMode(GLUT_RGB);

	glutCreateWindow("teapot!");
	glutDisplayFunc(display);
	glutKeyboardFunc(klawiatura);
	glutSpecialFunc(keyboardSpecialKeys);
	glutMainLoop();
}
