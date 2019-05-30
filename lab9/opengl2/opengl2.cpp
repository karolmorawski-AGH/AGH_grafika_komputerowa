// opengl2.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <stdlib.h>
#include "glut.h"
#include <vector>

double x = 0;
double y = 0;
double z = 0;

std::vector < GLint > vertex_x;
std::vector < GLint > vertex_y;

// sta³e do obs³ugi menu podrêcznego
enum
{
	TROJKAT, KWADRAT, EXIT, POINTS, LINES, LINE_STRIP, LINE_LOOP, QUADS, QUAD_STRIP, TRIANGLE_FAN, TRIANGLE_STRIP
};
int object;
void Display()
{
	glClearColor(0, 0, 0, 1);
	glClear(GL_COLOR_BUFFER_BIT);
	glMatrixMode(GL_MODELVIEW);
	glColor3f(255.0, 255.0, 255.0);
	switch (object)
	{
		// trojkat
	case TROJKAT: {
		glBegin(GL_TRIANGLES);
		// kolejne wierzcho³ki wielok¹ta
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 1.0, 0.0);
		glVertex3f(1.0, 1.0, 0.0);
		glEnd();

		glBegin(GL_TRIANGLES);
		// kolejne wierzcho³ki wielok¹ta
		glVertex3f(-1.0, -1.0, -1.0);
		glVertex3f(-2.0, -2.0, -2.0);
		glVertex3f(5.0, 4.0, 1.0);
		glEnd();


		break; }
				  // kwadrat
	case KWADRAT: {
		glBegin(GL_POLYGON);
		glVertex3f(0.0, 0.0, 0.0);
		glVertex3f(0.0, 1.0, 0.0);
		glVertex3f(1.0, 1.0, 0.0);
		glVertex3f(1.0, 0.0, 0.0);
		glVertex3f(-1.0, -2.0, 0.0);
		glVertex3f(-1.0, 0.0, 0.0);
		glEnd();
		break; }
	case POINTS: {
		glPointSize(3);
		glBegin(GL_POINTS);
		glVertex3f(x, y, 0.);
		glVertex3f(x+0.1, y+0.2, 0.);
		glVertex3f(x+0.6, y+0.5, 0.);
		glVertex3f(x+0.1, y+.0, 0.);
		glVertex3f(x+0.2,y+0.2,0.);
		glVertex3f(x+0.1, y+0.4, 0.);
		glEnd();
		break;
	}
	case LINES: {
		glLineWidth(3);
		glBegin(GL_LINES);
		glVertex3f(0., 0., 0.);
		glVertex3f(1., 1., 0.);

		glVertex3f(0.1, -0.2, 0.1);
		glVertex3f(1, .4, 0.1);
		glEnd();
		break;
	}
	case LINE_STRIP: {
		glLineWidth(3);
		glBegin(GL_LINE_STRIP);
		glVertex3f(0, 0, 0.);
		glVertex3f(-0.6, 1, 0.);
		glVertex3f(-0.8, -1, 0.);
		glVertex3f(-0.9, 2, 0.);

		glEnd();
		break;
	}
	case LINE_LOOP: {
		glLineWidth(3);
		glBegin(GL_LINE_LOOP);
		float pi = 3.14;
		for (float i = 0; i <  pi; i++)
		{
			glVertex3f(0.5* cos(i), 0.5* sin(i), 0.);
		}

		glEnd();
		break;
	}

	case QUADS: {
		glLineWidth(3);
		glBegin(GL_QUADS);
		glVertex3f(0, 0, 0);
		glVertex3f(1, 1, 0);
		glVertex3f(1, 1, 0);
		glVertex3f(0, 1, 0);
		glEnd();
		break;
	}
	case QUAD_STRIP: {
		glLineWidth(3);
		glBegin(GL_QUAD_STRIP);
		glVertex3f(0, 0, 0);
		glVertex3f(0.9, 0, 0);
		glVertex3f(0.8, 0.9, 0);
		glVertex3f(0, 0.8, 0);

		glVertex3f(0, 0.7, 0);
		glVertex3f(0.6, 0.7, 0);
		glVertex3f(0.5, 0, 0);
		glVertex3f(0, 0.1, 0);
		glEnd();
		break;
		break;
	}
	case TRIANGLE_FAN: {
		glBegin(GL_TRIANGLE_FAN);
		glVertex3f(0.0, 1.0, 0.0);
		glVertex3f(-0.7, -0.1, 0.0);
		glVertex3f(-0.8, 1.2, 0.0);
		glVertex3f(-0.2, 2.1, 0.0);
		glVertex3f(0.32, 0.5, 0.0);
		glVertex3f(0.4, -0.1, 0.0);
		glEnd();
		break; }
	case TRIANGLE_STRIP: {
		glBegin(GL_TRIANGLE_STRIP);
		glVertex3f(1.0, 0.6, 0.0);
		glVertex3f(-0.2, 0.25, 0.0);
		glVertex3f(-0.5, -0.5, 0.0);
		glVertex3f(0.5, 0.2, 0.0);
		glEnd();
		break;
	}
	}
	glFlush();
	glutSwapBuffers();
}
void Reshape(int width, int height)
{
	Display();
}
void Menu(int value)
{
	switch (value)
	{
		// TROJKAT
	case TROJKAT:
		object = TROJKAT;
		Display();
		break;
		// KWADRAT
	case KWADRAT:
		object = KWADRAT;
		Display();
		break;
		// wyjœcie
	case EXIT:
		exit(0);
	case POINTS:
		object = POINTS;
		Display();
		break;
	case LINES:
		object = LINES;
		Display();
		break;
	case LINE_STRIP:
		object = LINE_STRIP;
		Display();
		break;
	case LINE_LOOP:
		object = LINE_LOOP;
		Display();
		break;
	case QUADS:
		object = QUADS;
		Display();
		break;
	case QUAD_STRIP:
		object = QUAD_STRIP;
		Display();
		break;
	case TRIANGLE_FAN:
		object = TRIANGLE_FAN;
		Display();
		break;
	case TRIANGLE_STRIP:
		object = TRIANGLE_STRIP;
		Display();
		break;
	}


}
int main(int argc, char* argv[])
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutInitWindowSize(900, 900);
	glutCreateWindow("Pierwszy program");
	glutDisplayFunc(Display);
	glutReshapeFunc(Reshape);
	glutCreateMenu(Menu);
	glutAddMenuEntry("POINTS", POINTS);
	glutAddMenuEntry("LINES", LINES);
	glutAddMenuEntry("LINE_STRIP", LINE_STRIP);
	glutAddMenuEntry("LINE_LOOP", LINE_LOOP);
	glutAddMenuEntry("TRIANGLES", TROJKAT);
	glutAddMenuEntry("TRIANGLE_STRIP", TRIANGLE_STRIP);
	glutAddMenuEntry("TRIANGLE_FAN", TRIANGLE_FAN);
	glutAddMenuEntry("QUADS", QUADS);
	glutAddMenuEntry("QUAD_STRIP", QUAD_STRIP);
	glutAddMenuEntry("POLYGON", KWADRAT);
	glutAddMenuEntry("wyjscie", EXIT);
	glutAttachMenu(GLUT_RIGHT_BUTTON);
	glutMainLoop();
	return 0;
}

