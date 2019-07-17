#!/usr/bin/env python

import sys, os, argparse

if __name__ == '__main__':
    args = argparse.ArgumentParser(description="", epilog="" )
    args.add_argument('targets', type=str, nargs='+', help="Target file", metavar='target')
    args = args.parse_args()

    pattern = 'libmpfr-6.dll'.encode('utf-8')
    replacement = 'libmpfr-4.dll'.encode('utf-8')

    for target in args.targets:
        if not os.path.exists(target):
            print("File does not not exist")
            sys.exit(1)

        with open(target, 'rb') as f:
            content = f.read()

        if content.find(pattern) == -1:
            if content.find(replacement) != -1:
                print("File already patched, skipping...")
            else:
                print("Pattern not found")
                sys.exit(1)

        content = content.replace(pattern, replacement, 1)
        os.remove(target);

        if os.path.exists(target):
            print("Output file exist")
            sys.exit(1)

        with open(target, "wb+") as f:
            f.write(content)

    sys.exit()
