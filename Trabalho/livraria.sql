-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 03/12/2023 às 17:16
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `livraria`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `clientes`
--

CREATE TABLE `clientes` (
  `nome` varchar(10) NOT NULL,
  `email` varchar(30) NOT NULL,
  `senha` varchar(12) NOT NULL,
  `dtnasc` varchar(15) NOT NULL,
  `cep` varchar(9) NOT NULL,
  `endereco` varchar(50) NOT NULL,
  `bairro` varchar(50) NOT NULL,
  `cidade` varchar(20) NOT NULL,
  `numero` varchar(10) NOT NULL,
  `uf` varchar(5) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `plano` varchar(20) NOT NULL,
  `cobranca` varchar(20) NOT NULL,
  `fretegratis` varchar(20) NOT NULL,
  `fretepago` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `clientes`
--

INSERT INTO `clientes` (`nome`, `email`, `senha`, `dtnasc`, `cep`, `endereco`, `bairro`, `cidade`, `numero`, `uf`, `telefone`, `plano`, `cobranca`, `fretegratis`, `fretepago`) VALUES
('master', 'master@gmail.com', '123456', '12/03/2001', '027898100', 'rua dos andrades', 'imirim', 'sao paulo', '98', 'sp', '11987654321', 'simples', 'sim', 'sim', 'nao');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`nome`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
