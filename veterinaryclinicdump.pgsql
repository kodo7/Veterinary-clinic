--
-- PostgreSQL database dump
--

-- Dumped from database version 12.2
-- Dumped by pg_dump version 12.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: lietotajs; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.lietotajs (
    lietotajs_id integer NOT NULL,
    lietotajvards character varying(50),
    parole character varying(50),
    epasts character varying(255),
    vards character varying(40) NOT NULL,
    uzvards character varying(40) NOT NULL
);


ALTER TABLE public.lietotajs OWNER TO postgres;

--
-- Name: lietotajs_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.lietotajs_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.lietotajs_id_seq OWNER TO postgres;

--
-- Name: lietotajs_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.lietotajs_id_seq OWNED BY public.lietotajs.lietotajs_id;


--
-- Name: lietotajs_tips; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.lietotajs_tips (
    lietotajs_tips_id integer NOT NULL,
    tips_id integer NOT NULL,
    lietotajs_id integer NOT NULL
);


ALTER TABLE public.lietotajs_tips OWNER TO postgres;

--
-- Name: lietotajs_tips_lietotajs_tips_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.lietotajs_tips_lietotajs_tips_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.lietotajs_tips_lietotajs_tips_id_seq OWNER TO postgres;

--
-- Name: lietotajs_tips_lietotajs_tips_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.lietotajs_tips_lietotajs_tips_id_seq OWNED BY public.lietotajs_tips.lietotajs_tips_id;


--
-- Name: majdzivnieks; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.majdzivnieks (
    majdzivnieks_id integer NOT NULL,
    vards character varying(40) NOT NULL,
    suga character varying(40) NOT NULL,
    dzimums character varying(40) NOT NULL,
    vecums_menesi integer,
    lietotajs_id integer NOT NULL
);


ALTER TABLE public.majdzivnieks OWNER TO postgres;

--
-- Name: majdzivnieks_majdzivnieks_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.majdzivnieks_majdzivnieks_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.majdzivnieks_majdzivnieks_id_seq OWNER TO postgres;

--
-- Name: majdzivnieks_majdzivnieks_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.majdzivnieks_majdzivnieks_id_seq OWNED BY public.majdzivnieks.majdzivnieks_id;


--
-- Name: pieraksts; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pieraksts (
    pieraksts_id integer NOT NULL,
    laiks character varying(255) NOT NULL,
    iemesls character varying(255) NOT NULL,
    piezimes character varying(1000),
    lietotajs_id integer NOT NULL,
    majdzivnieks_id integer NOT NULL,
    datums date NOT NULL
);


ALTER TABLE public.pieraksts OWNER TO postgres;

--
-- Name: pieraksts_pieraksts_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pieraksts_pieraksts_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.pieraksts_pieraksts_id_seq OWNER TO postgres;

--
-- Name: pieraksts_pieraksts_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pieraksts_pieraksts_id_seq OWNED BY public.pieraksts.pieraksts_id;


--
-- Name: tips; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tips (
    tips_id integer NOT NULL,
    tips character varying(255) NOT NULL
);


ALTER TABLE public.tips OWNER TO postgres;

--
-- Name: tips_tips_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tips_tips_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tips_tips_id_seq OWNER TO postgres;

--
-- Name: tips_tips_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tips_tips_id_seq OWNED BY public.tips.tips_id;


--
-- Name: lietotajs lietotajs_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lietotajs ALTER COLUMN lietotajs_id SET DEFAULT nextval('public.lietotajs_id_seq'::regclass);


--
-- Name: lietotajs_tips lietotajs_tips_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lietotajs_tips ALTER COLUMN lietotajs_tips_id SET DEFAULT nextval('public.lietotajs_tips_lietotajs_tips_id_seq'::regclass);


--
-- Name: majdzivnieks majdzivnieks_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.majdzivnieks ALTER COLUMN majdzivnieks_id SET DEFAULT nextval('public.majdzivnieks_majdzivnieks_id_seq'::regclass);


--
-- Name: pieraksts pieraksts_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pieraksts ALTER COLUMN pieraksts_id SET DEFAULT nextval('public.pieraksts_pieraksts_id_seq'::regclass);


--
-- Name: tips tips_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tips ALTER COLUMN tips_id SET DEFAULT nextval('public.tips_tips_id_seq'::regclass);


--
-- Data for Name: lietotajs; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.lietotajs (lietotajs_id, lietotajvards, parole, epasts, vards, uzvards) FROM stdin;
23	klients	test	janis@inbox.lv	janis	berzins
24	darbinieks	test	andris@inbox.lv	andris	kalnins
32	klients2	test	kalnins@inbox.lv	janis	kalnins
34	\N	\N	\N	maris	akmens
35	klients3	test	test@test.lv	aaa	aaa
36	\N	\N	\N	Elvijs	Raudis
\.


--
-- Data for Name: lietotajs_tips; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.lietotajs_tips (lietotajs_tips_id, tips_id, lietotajs_id) FROM stdin;
2	1	23
3	2	24
8	1	32
9	1	35
\.


--
-- Data for Name: majdzivnieks; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.majdzivnieks (majdzivnieks_id, vards, suga, dzimums, vecums_menesi, lietotajs_id) FROM stdin;
15	maksis	suns	Viriesu	26	23
16	dhdfh	dfgdfg	Viriesu	100	23
17	Reksis	suns	Sieviesu	55	32
18	Cat	kakis	Viriesu	23	32
19	aaaa	aligators	Viriesu	23	23
20	test6	test6	Viriesu	100	23
21	test455	test544	Viriesu	43	32
22	test777	test777	Viriesu	100	23
23	test3456346	saddsad	Viriesu	100	32
24	fdgsdgf	sdfsdf	Viriesu	100	23
25	fghfgh	hfghfgh	Viriesu	100	23
26	Dog	Dog	Viriesu	22	34
27	jj	jj	Viriesu	3	32
28	Reksis	suns	Viriesu	4	35
29	Reksis	suns	Viriesu	3	36
\.


--
-- Data for Name: pieraksts; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pieraksts (pieraksts_id, laiks, iemesls, piezimes, lietotajs_id, majdzivnieks_id, datums) FROM stdin;
6	9:30	Apskate		23	15	2022-01-09
7	13:00	Apskate		23	16	2022-01-09
8	13:30	Vakcinacija	test	32	17	2022-01-09
9	8:30	Cits	test	32	17	2022-01-09
10	9:00	Cits	test	32	18	2022-01-09
11	10:00	Vakcinacija	test	23	19	2022-01-09
12	11:30	Cits	aa	23	19	2022-01-09
13	10:30	Apskate	test7	23	20	2022-01-09
14	11:00	Apskate	aa	23	20	2022-01-09
15	12:00	Apskate	fgfgdf	32	21	2022-01-09
16	14:30	Cits	fgjfgj	23	22	2022-01-09
17	12:30	Vakcinacija	ttt	32	23	2022-01-09
18	14:00	Cits	asdasdsa	23	24	2022-01-09
19	15:00	Apskate	asfsaffsa	23	19	2022-01-09
20	10:00	Apskate	dfdfg	23	25	2022-01-10
21	12:00	Apskate	sadasd	23	25	2022-01-10
22	8:30	Apskate	dfhdfh	34	26	2022-01-10
23	10:30	Apskate	jj	32	18	2022-01-18
24	15:30	Vakcinacija	fff	23	15	2022-01-19
25	9:00	Vakcinacija	jsadsad	35	28	2022-01-10
26	9:30	Vakcinacija	hhh	35	28	2022-01-10
27	10:30	Apskate	ssdd	36	29	2022-01-10
\.


--
-- Data for Name: tips; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tips (tips_id, tips) FROM stdin;
1	klients
2	darbinieks
\.


--
-- Name: lietotajs_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.lietotajs_id_seq', 36, true);


--
-- Name: lietotajs_tips_lietotajs_tips_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.lietotajs_tips_lietotajs_tips_id_seq', 9, true);


--
-- Name: majdzivnieks_majdzivnieks_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.majdzivnieks_majdzivnieks_id_seq', 29, true);


--
-- Name: pieraksts_pieraksts_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pieraksts_pieraksts_id_seq', 27, true);


--
-- Name: tips_tips_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tips_tips_id_seq', 2, true);


--
-- Name: lietotajs lietotajs_email_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lietotajs
    ADD CONSTRAINT lietotajs_email_key UNIQUE (epasts);


--
-- Name: lietotajs lietotajs_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lietotajs
    ADD CONSTRAINT lietotajs_pkey PRIMARY KEY (lietotajs_id);


--
-- Name: lietotajs_tips lietotajs_tips_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lietotajs_tips
    ADD CONSTRAINT lietotajs_tips_pkey PRIMARY KEY (lietotajs_tips_id);


--
-- Name: lietotajs lietotajs_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lietotajs
    ADD CONSTRAINT lietotajs_username_key UNIQUE (lietotajvards);


--
-- Name: majdzivnieks majdzivnieks_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.majdzivnieks
    ADD CONSTRAINT majdzivnieks_pkey PRIMARY KEY (majdzivnieks_id);


--
-- Name: pieraksts pieraksts_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pieraksts
    ADD CONSTRAINT pieraksts_pkey PRIMARY KEY (pieraksts_id);


--
-- Name: tips tips_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tips
    ADD CONSTRAINT tips_pkey PRIMARY KEY (tips_id);


--
-- Name: tips tips_tips_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tips
    ADD CONSTRAINT tips_tips_key UNIQUE (tips);


--
-- Name: lietotajs_tips lietotajs_tips_lietotajs_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lietotajs_tips
    ADD CONSTRAINT lietotajs_tips_lietotajs_id_fkey FOREIGN KEY (lietotajs_id) REFERENCES public.lietotajs(lietotajs_id);


--
-- Name: lietotajs_tips lietotajs_tips_tips_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.lietotajs_tips
    ADD CONSTRAINT lietotajs_tips_tips_id_fkey FOREIGN KEY (tips_id) REFERENCES public.tips(tips_id);


--
-- Name: majdzivnieks majdzivnieks_lietotajs_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.majdzivnieks
    ADD CONSTRAINT majdzivnieks_lietotajs_id_fkey FOREIGN KEY (lietotajs_id) REFERENCES public.lietotajs(lietotajs_id);


--
-- Name: pieraksts pieraksts_lietotajs_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pieraksts
    ADD CONSTRAINT pieraksts_lietotajs_id_fkey FOREIGN KEY (lietotajs_id) REFERENCES public.lietotajs(lietotajs_id);


--
-- PostgreSQL database dump complete
--

