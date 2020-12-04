#include <SFML/Graphics.hpp>
#include <time.h>
#include <list>
#include <SFML/Audio.hpp>
#include <sstream>
#include "LifeBar.h"
#include <iostream>
#include <Windows.h>


using namespace std;
using namespace sf;

const int W = 800;
const int H = 600;
int mylife = 100;//хитпоинты
int level = 1;//уровень сложности
int towerlvl = 1;//уровень башни
float DEGTORAD = 0.017453f;

class Animation
{
public:
	float Frame, speed;
	Sprite sprite;
	std::vector<IntRect> frames;

	Animation() {}

	Animation(Texture &t, int x, int y, int w, int h, int count, float Speed)
	{
		Frame = 0;
		speed = Speed;

		for (int i = 0; i<count; i++)
			frames.push_back(IntRect(x + i*w, y, w, h));

		sprite.setTexture(t);
		sprite.setOrigin(w / 2, h / 2);
		sprite.setTextureRect(frames[0]);
	}


	void update()
	{
		Frame += speed;
		int n = frames.size();
		if (Frame >= n) Frame -= n;
		if (n>0) sprite.setTextureRect(frames[int(Frame)]);
	}

	bool isEnd()
	{
		return Frame + speed >= frames.size();
	}

};


class Entity
{
public:
	float x, y, dx, dy, R, angle;
	bool life;
	std::string name;
	Animation anim;

	Entity()
	{
		life = 1;
	}

	void settings(Animation &a, int X, int Y, float Angle = 0, int radius = 1)
	{
		anim = a;
		x = X; y = Y;
		angle = Angle;
		R = radius;
	}

	virtual void update() {};

	void draw(RenderWindow &app)
	{
		anim.sprite.setPosition(x, y);
		anim.sprite.setRotation(angle + 90);
		app.draw(anim.sprite);

		CircleShape circle(R);
		circle.setFillColor(Color(255, 0, 0, 170));
		circle.setPosition(x, y);
		circle.setOrigin(R, R);
		//app.draw(circle);
	}

	virtual ~Entity() {};
};


class asteroid : public Entity
{
public:
	asteroid()
	{
		//dx = rand() % 8 - 4;
		//dy = rand() % 8 - 4;
		dx = -1*level;
		dy = 0;
		name = "asteroid";
	}

	void  update()
	{
		x += dx;
		y += dy;

		if (x > W) 
		{
			x = 0;
			//mylife = mylife - 5;
		}
		if (x < 0)
		{
			x = W;
			//mylife = mylife - 5;
		}
		if (x == 30) 
		{
			mylife = mylife - 5;
		}
		if (y>H) y = 0;  if (y<0) y = H;
	}

};



class bullet : public Entity
{
public:
	bullet()
	{
		name = "bullet";
	}

	void  update()
	{
		dx = cos(angle*DEGTORAD) * 6;
		dy = sin(angle*DEGTORAD) * 6;
		// angle+=rand()%6-3;
		x += dx;
		y += dy;

		if (x>W || x<0 || y>H || y<0) life = 0;
	}

};


class player : public Entity
{
public:
	bool thrust;

	player()
	{
		name = "player";
	}

	void update()
	{
		if (thrust)
		{
			dx += cos(angle*DEGTORAD)*0.2;
			dy += sin(angle*DEGTORAD)*0.2;
		}
		else
		{
			dx *= 0.99;
			dy *= 0.99;
		}

		int maxSpeed = 15;
		float speed = sqrt(dx*dx + dy*dy);
		if (speed>maxSpeed)
		{
			dx *= maxSpeed / speed;
			dy *= maxSpeed / speed;
		}

		x += dx;
		y += dy;

		if (x>W) x = 0; if (x<0) x = W;
		if (y>H) y = 0; if (y<0) y = H;
	}

};


bool isCollide(Entity *a, Entity *b)
{
	return (b->x - a->x)*(b->x - a->x) +
		(b->y - a->y)*(b->y - a->y)<
		(a->R + b->R)*(a->R + b->R);
}


int main()
{
	srand(time(0));
	RenderWindow app(VideoMode(W, H), "TowerDefence!");
	app.setPosition(sf::Vector2i(250, 50));
	app.setFramerateLimit(60);
	//фоновые звуки//
	sf::SoundBuffer buffer;
	buffer.loadFromFile("musik.ogg");// тут загружаем в буфер что то
	sf::Sound sound;
	sound.setBuffer(buffer);
	sound.play();
	SoundBuffer shootBuffer;//создаём буфер для звука
	shootBuffer.loadFromFile("shoot.ogg");//загружаем в него звук
	Sound shoot(shootBuffer);//создаем звук и загружаем в него звук из буфера
	///////////////
	//инициализируем работу с текстовой информацией//
	Font font;
	font.loadFromFile("CyrilicOld.TTF");
	Text text("", font, 20);
	//text.setColor(Color::Red);
	text.setStyle(sf::Text::Bold);
	text.setPosition(550, 10);
	////////////////////////////////////////////////
	int gold = 0; //переменная отвечает за подсчет количества золота
	int kuv = 0; //количество убитых врагов
	LifeBar lifeBarPlayer;//полоска здоровья
	srand(time(0));
	Texture t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15;
	t1.loadFromFile("images/tower.png");
	t2.loadFromFile("images/background.jpg");
	t3.loadFromFile("images/explosions/type_C.png");
	t4.loadFromFile("images/enemy.png");
	t5.loadFromFile("images/fire_red.png");
	t6.loadFromFile("images/coins.png");
	t7.loadFromFile("images/explosions/type_B.png");
	t8.loadFromFile("images/tower1.png");
	t9.loadFromFile("images/background2.jpg");
	t10.loadFromFile("images/background3.jpg");
	t11.loadFromFile("images/background4.jpg");
	t12.loadFromFile("images/background5.jpg");
	t13.loadFromFile("images/go.png");
	t14.loadFromFile("images/pause.png");
	t15.loadFromFile("images/menus.png");


	t1.setSmooth(true);
	t2.setSmooth(true);

	Sprite background(t2);
	Sprite background1(t9);
	Sprite background2(t10);
	Sprite background3(t11);
	Sprite background4(t12);
	Sprite gover;
	gover.setTexture(t13);
	gover.setPosition(0, 0);
	Sprite pauses(t14);
	Sprite menus(t15);


	//тут у нас типо меню////////////////////////
	RenderWindow menu(VideoMode(W / 2, H / 2), "MeinMenu!");
	menu.setPosition(sf::Vector2i(450, 200));
	menu.setFramerateLimit(60);
	// пусть программа работает до тех пор, пока открыто окно
	while (menu.isOpen())
	{
		// проверить все события окна, которые были вызваны с последней итерации цикла
		sf::Event event;
		while (menu.pollEvent(event))
		{
			// "запрос закрытия" событие: мы закрываем окно
			if (Keyboard::isKeyPressed(Keyboard::F1))
				menu.close();
			if (Keyboard::isKeyPressed(Keyboard::F2))
			{
				menu.close();
				app.close();
			}
		}
		menu.draw(menus);
		menu.display();
	}
	////////////////////////////////////////////



	Animation sExplosion(t3, 0, 0, 256, 256, 48, 0.5);
	Animation sRock(t4, 0, 0, 64, 64, 8, 0.3);
	Animation sRock_small(t6, 0, 0, 30, 30, 8, 0.2);
	Animation sBullet(t5, 0, 0, 32, 64, 16, 0.8);
	Animation sPlayer(t1, 0, 0, 44, 66, 1, 0);
	Animation sPlayer_go(t1, 40, 40, 40, 40, 1, 0);
	Animation sExplosion_ship(t7, 0, 0, 192, 192, 64, 0.5);
	Animation sPlayer1(t8, 0, 0, 66, 66, 1, 0);

	std::list<Entity*> entities;

	for (int i = 0; i<7; i++)
	{
		asteroid *a = new asteroid();
		a->settings(sRock, rand() % W, rand() % H, 270, 25);
		entities.push_back(a);
	}

	player *p = new player();
	p->settings(sPlayer, 30, H / 2, 0, 20);
	entities.push_back(p);


	/////главный цикл/////
	while (app.isOpen())
	{
		Event event;
		while (app.pollEvent(event))
		{
			if (event.type == Event::Closed)
				app.close();

			//в завсимости от уровня башни устанавливаем стрельбу
			if (event.type == Event::KeyPressed)
				if (event.key.code == Keyboard::Up || event.key.code == Keyboard::Space)
				{
					if (towerlvl == 1)
					{
						shoot.play();//играем звук пули
						bullet *b = new bullet();
						//bullet *z = new bullet();//test
						b->settings(sBullet, p->x, p->y, p->angle, 10);
						//z->settings(sBullet, p->x+10, p->y+10, p->angle, 10);//test
						entities.push_back(b);
						//entities.push_back(z);//test
					}
					if (towerlvl == 2)
					{
						shoot.play();//играем звук пули
						bullet *b = new bullet();
						bullet *z = new bullet();//test
						b->settings(sBullet, p->x, p->y-10, p->angle, 10);
						z->settings(sBullet, p->x, p->y+10, p->angle, 10);//test
						entities.push_back(b);
						entities.push_back(z);//test
					}
				}
		}
		////////////////////////////////////////////////////////////////////////////

		//gameover/////////////////////////продумать, посмотреть как сделано в основном цикле///////////////////////////////////
		if (mylife<=0)
		{
				RenderWindow go(VideoMode(W / 2, H / 2), "GameOver!");
				//sf::Window go(sf::VideoMode(400, 300), "GameOver!");
				go.setPosition(sf::Vector2i(450, 200));
				go.setFramerateLimit(60);
				mylife = 100;
				gold = 0;
				towerlvl = 1;
				level = 1;
				kuv = 0;
				// пусть программа работает до тех пор, пока открыто окно
				while (go.isOpen())
				{
					// проверить все события окна, которые были вызваны с последней итерации цикла
					sf::Event event;
					while (go.pollEvent(event))
					{
						// "запрос закрытия" событие: мы закрываем окно
						if (event.type == sf::Event::Closed || Keyboard::isKeyPressed(Keyboard::Escape))
							go.close();
					}
					go.draw(gover);
					go.display();
				}
		}
		///////////////////////////////////////////////////////////////////////////

		if (Keyboard::isKeyPressed(Keyboard::Right)) p->angle += 3;
		if (Keyboard::isKeyPressed(Keyboard::Left))  p->angle -= 3;

		//нажатием клавиши таб вызывает окно которое может содержать таблицу рекордов или бла бла бла
		if (Keyboard::isKeyPressed(Keyboard::Tab))
		{
			RenderWindow pause(VideoMode(W / 2, H / 2), "Pause!");
			//sf::Window go(sf::VideoMode(400, 300), "GameOver!");
			pause.setPosition(sf::Vector2i(450, 200));
			pause.setFramerateLimit(60);
			// пусть программа работает до тех пор, пока открыто окно
			while (pause.isOpen())
			{
				// проверить все события окна, которые были вызваны с последней итерации цикла
				sf::Event event;
				while (pause.pollEvent(event))
				{
					// "запрос закрытия" событие: мы закрываем окно
					if (event.type == sf::Event::Closed || Keyboard::isKeyPressed(Keyboard::Escape))
						pause.close();
				}
				pause.draw(pauses);
				pause.display();
			}
		}
		/////////////////////////////////////////////////////////////////////////////////////////////

		//клавишей Х подымаем уровень башни////////////////////
		if (Keyboard::isKeyPressed(Keyboard::X) && gold >= 100)
		{
			towerlvl = 2;
			gold = gold - 100;
		}
		//////////////////////////////////////////////////////////



		//уровни сложности///////
		if (kuv == 10)level = 1;
		if (kuv == 50)level = 2;
		if (kuv == 100)level = 3;
		if (kuv == 250)level = 4;
		if (kuv == 500)level = 5;
		//////////////////////////


		//выводит количество заработанного золота, убитых врагов, уровня//////////////////////
		std::ostringstream playergoldString;//заработано золота    
		playergoldString << gold;
		std::ostringstream playerdeathString;//убито врагов
		playerdeathString << kuv;
		std::ostringstream curlev;//текущий лвл
		curlev << level;
		text.setString("Заработано золота:" + playergoldString.str() + "\nКоличество убитых:" + playerdeathString.str() + "\nТекущий уровень:" + curlev.str());
		///////////////////////////////////////////////////////////////
		lifeBarPlayer.update(mylife);//обновляем хитбокс
		for (auto a : entities)
			for (auto b : entities)
			{
				if (a->name == "asteroid" && b->name == "bullet")
					if (isCollide(a, b))
					{
						a->life = false;
						b->life = false;
						if (a->R != 15)
						{
							kuv = kuv + 1;//количество убитых врагов
						}
						else 
						{
							//здесь подсчитывается заработанное золото
							gold++;
							//////////////////////////////////////////
						}

						Entity *e = new Entity();
						e->settings(sExplosion, a->x, a->y);
						e->name = "explosion";
						entities.push_back(e);


						for (int i = 0; i<2; i++)
						{
							if (a->R == 15)
							{
								continue;
							}
							Entity *e = new asteroid();
							e->settings(sRock_small, a->x, a->y, 270, 15);
							entities.push_back(e);
						}

					}

				if (a->name == "player" && b->name == "asteroid")
					if (isCollide(a, b))
					{
						b->life = false;
						mylife = mylife - 10;//при столкноении уменьшаются собственные хп
						Entity *e = new Entity();
						e->settings(sExplosion_ship, a->x, a->y);
						e->name = "explosion";
						entities.push_back(e);
						//перерисовка в зависимости от уровня башни
						if (towerlvl == 1)
						{
							p->settings(sPlayer, 30, H / 2, 0, 20);
							p->dx = 0; p->dy = 0;
						}
						if(towerlvl==2)
						{
							p->settings(sPlayer1, 30, H / 2, 0, 20);
							p->dx = 0; p->dy = 0;
						}
					}
			}


		if (p->thrust)  p->anim = sPlayer_go;
		else
		{
			//отрисовка в зависимости от уровня башни
			if (towerlvl == 1) p->anim = sPlayer;
			if (towerlvl == 2) p->anim = sPlayer1;
		}


		for (auto e : entities)
			if (e->name == "explosion")
				if (e->anim.isEnd()) e->life = 0;

		if (rand() % 150 == 0)
		{
			asteroid *a = new asteroid();
			a->settings(sRock, 0, rand() % H, 270, 25);
			entities.push_back(a);
		}

		for (auto i = entities.begin(); i != entities.end();)
		{
			Entity *e = *i;

			e->update();
			e->anim.update();

			if (e->life == false) { i = entities.erase(i); delete e; }
			else i++;
		}


	
		



		//////draw//////
		if (level == 1) 
		{
			app.draw(background);//фон
		}
		if (level == 2)
		{
			app.draw(background1);//фон
		}
		if (level == 3)
		{
			app.draw(background2);//фон
		}
		if (level == 4)
		{
			app.draw(background3);//фон
		}
		if (level == 5)
		{
			app.draw(background4);//фон
		}
		app.draw(text);//текстовая информация
		lifeBarPlayer.draw(app);
		for (auto i : entities)//все остальное
			i->draw(app);

		app.display();
	}

	return 0;
}
